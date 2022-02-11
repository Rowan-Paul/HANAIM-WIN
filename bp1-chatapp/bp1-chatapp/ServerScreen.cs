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
        private List<TcpClient> clientsConnected = new List<TcpClient>();
        private NetworkStream _networkStream;

        public ServerScreen()
        {
            InitializeComponent();
        }

        private async void CreateServer(String ip, Int32 port)
        {
            try
            {
                _server = new TcpListener(IPAddress.Parse(ip), port);
                _server.Start();

                while (true)
                {
                    _client = await _server.AcceptTcpClientAsync();

                    clientsConnected.Add(_client);
                    await Task.Run(async () =>
                    {
                        byte[] buffer = new byte[256];
                        _networkStream = _client.GetStream();

                        while (_networkStream.CanRead)
                        {
                            int bytes = await _networkStream.ReadAsync(buffer, 0, 256);
                            string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                            if (_networkStream.CanRead)
                            {
                                byte[] serverMessageByteArray = Encoding.ASCII.GetBytes(message);
                                await _networkStream.WriteAsync(serverMessageByteArray, 0,
                                    serverMessageByteArray.Length);

                                Console.WriteLine("Server received: {0}", message);
                                chatBox.Items.Add(message);
                            }
                        }
                    });
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                _server.Stop();
            }
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            bufferInput.Enabled = false;
            startServerButton.Text = "Stop server";

            CreateServer(ipInput.Text, 3000);
        }
    }
}