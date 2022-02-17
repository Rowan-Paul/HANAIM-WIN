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

        public ServerScreen()
        {
            InitializeComponent();

            stopServerButton.Visible = false;
            chatBox.SelectedIndex = chatBox.Items.Count - 1;
        }

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
                        if (message.ToString().Contains("--"))
                        {
                            char[] delimiter = "--".ToCharArray();
                            string[] msgArray = message.ToString().Split(delimiter);

                            chatBox.Items.Add(msgArray[2] + ": " + msgArray[0]);
                            await SendMessages(msgArray[2] + ": " + msgArray[0]);
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

        private void startServerButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(portInput.Text, out var port) &&
                int.TryParse(bufferInput.Text, out var bufferSize) &&
                IPAddress.TryParse(ipInput.Text, out IPAddress ip))
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
                chatBox.Items.Add("IP, port or buffersize not correct");
            }
        }

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
    }
}