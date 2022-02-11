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

        private async void CreateServer(String ip, Int32 port, int bufferSize)
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
                        byte[] buffer = new byte[bufferSize];
                        _networkStream = _client.GetStream();

                        while (_networkStream.CanRead)
                        {
                            int bytes = await _networkStream.ReadAsync(buffer, 0, bufferSize);
                            string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                            if (_networkStream.CanRead)
                            {
                                byte[] serverMessageByteArray = Encoding.ASCII.GetBytes(message);
                                await _networkStream.WriteAsync(serverMessageByteArray, 0,
                                    serverMessageByteArray.Length);

                                chatBox.Items.Add(message);
                            }
                        }
                    });
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException Server: {0}", e);
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