using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bp1_chatapp
{
    public partial class ServerScreen : Form
    {
        private TcpClient _client;
        private TcpListener _server;
        private List<TcpClient> _clientsConnected = new List<TcpClient>();

        /*
         * Initializes the server
         */
        public ServerScreen()
        {
            InitializeComponent();

            stopServerButton.Visible = false;
            chatBox.SelectedIndex = chatBox.Items.Count - 1;
            ipInput.Text = "127.0.0.1";
            portInput.Text = "3000";
            bufferInput.Text = "256";
        }

        /*
         * Creates a server
         * @param ip IP to create server on
         * @param port Port for the server
         * @param bufferSize Buffer size for the server
         */
        private async void CreateServer(IPAddress ip, int port, int bufferSize)
        {
            try
            {
                _server = new TcpListener(ip, port);
                _server.Start();
                chatBox.Items.Add("Server started");

                while (true)
                {
                    _client = await _server.AcceptTcpClientAsync();
                    _clientsConnected.Add(_client);

                    await Task.Run(() => MessagesReceiver(_client, bufferSize));
                }
            }
            catch (SocketException)
            {
                chatBox.Items.Add("Can't start server, try different ip/port");
            }
            catch (Exception e)
            {
                Console.WriteLine("Server {0}", e);
            }
            finally
            {
                _server.Stop();

                ipInput.Enabled = true;
                portInput.Enabled = true;
                bufferInput.Enabled = true;
                startServerButton.Visible = true;
                stopServerButton.Visible = false;
            }
        }

        /*
         * Receives messages and sends them to clients
         * @param client The connected client
         * @param bufferSize The buffer size for the server
         */
        private async void MessagesReceiver(TcpClient client, int bufferSize)
        {
            NetworkStream networkStream = client.GetStream();

            try
            {
                while (networkStream.CanRead)
                {
                    byte[] myReadBuffer = new byte[bufferSize];
                    StringBuilder message = new StringBuilder();

                    do
                    {
                        int numberOfBytesRead =
                            await networkStream.ReadAsync(myReadBuffer, 0, myReadBuffer.Length);
                        message.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
                    } while (networkStream.DataAvailable);

                    if (message.Length > 0)
                    {
                        if (message.ToString().StartsWith("--u"))
                        {   
                            message.Remove(0, 3);

                            chatBox.Items.Add(message);
                            await SendMessages(message.ToString());
                        }
                        else
                        {
                            chatBox.Items.Add(message);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Server: {0}", e);
            }
        }

        /*
         * Sends messages to all clients
         * @param message The message to send
         */
        private async Task SendMessages(string message)
        {
            if (_clientsConnected.Count <= 0) return;
            foreach (TcpClient client in _clientsConnected)
            {
                try
                {
                    NetworkStream networkStream = client.GetStream();

                    if (!networkStream.CanRead) continue;
                    byte[] serverMessageByteArray = Encoding.ASCII.GetBytes(message);
                    await networkStream.WriteAsync(serverMessageByteArray, 0, serverMessageByteArray.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Server {0}", e);
                }
            }
        }

        /*
         * On Click: Starts server
         */
        private void startServerButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(portInput.Text, out var port) && port <= 65535 && port > 0)
            {
                if (int.TryParse(bufferInput.Text, out var bufferSize) && bufferSize > 0 && bufferSize < 1024)
                {
                    if (IPAddress.TryParse(ipInput.Text, out var ip))
                    {
                        ipInput.Enabled = false;
                        portInput.Enabled = false;
                        bufferInput.Enabled = false;
                        startServerButton.Visible = false;
                        stopServerButton.Visible = true;

                        CreateServer(ip, port, bufferSize);
                    }
                    else
                    {
                        chatBox.Items.Add("IP not correct");
                    }
                }
                else
                {
                    chatBox.Items.Add("Buffersize not correct");
                }
            }
            else
            {
                chatBox.Items.Add("Port not correct");
            }
        }

        /*
         * On Click: Stops server
         */
        private void stopServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                chatBox.Items.Add("Server stopped");

                foreach (TcpClient client in _clientsConnected)
                {
                    client.Close();
                }

                _server.Stop();

                ipInput.Enabled = true;
                portInput.Enabled = true;
                bufferInput.Enabled = true;
                startServerButton.Visible = true;
                stopServerButton.Visible = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Server {0}", exception);
            }
        }

        /*
         * When closing server by window, stop server
         */
        private void ServerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result =
                    MessageBox.Show("Are you sure you want to shut down the server?",
                        "Close Server", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    stopServerButton.PerformClick();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}