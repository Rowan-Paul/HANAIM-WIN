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
        }

        private async void CreateServer(string ip, int port, int bufferSize)
        {
            try
            {
                _server = new TcpListener(IPAddress.Parse(ip), port);
                _server.Start();
                chatBox.Items.Add("Server started");

                while (true)
                {
                    _client = await _server.AcceptTcpClientAsync();
                    _clientsConnected.Add(_client);
                    await Task.Run(() => MessageReceiver(_client, bufferSize));
                }
            }
            catch (SocketException)
            {
                chatBox.Items.Add("Can't start server, try different ip/port");
            }
            catch (ObjectDisposedException)
            {
                // TODO: stop server & connected clients
                chatBox.Items.Add("The server has been stopped");
            }
        }

        private async void MessageReceiver(TcpClient client, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            NetworkStream networkStream = client.GetStream();

            while (true)
            {
                while (networkStream.CanRead)
                {
                    try
                    {
                        int bytes = await networkStream.ReadAsync(buffer, 0, bufferSize);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                        chatBox.Items.Add(message);
                        await SendMessages(message);
                    }
                    catch (ObjectDisposedException)
                    {
                        chatBox.Items.Add("Client disconnected.");
                    }
                }
            }
        }

        private async Task SendMessages(string message)
        {
            if (_clientsConnected.Count <= 0) return;
            foreach (TcpClient client in _clientsConnected)
            {
                NetworkStream networkStream = client.GetStream();

                if (!networkStream.CanRead) continue;
                byte[] serverMessageByteArray = Encoding.ASCII.GetBytes(message);
                await networkStream.WriteAsync(serverMessageByteArray, 0, serverMessageByteArray.Length);
            }
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            bufferInput.Enabled = false;
            startServerButton.Visible = false;

            if (int.TryParse(portInput.Text, out var port) && int.TryParse(bufferInput.Text, out var bufferSize))
            {
                CreateServer(ipInput.Text, port, bufferSize);
            }
            else
            {
                Console.WriteLine("Server: Port or buffersize not a number");
            }
        }
    }
}