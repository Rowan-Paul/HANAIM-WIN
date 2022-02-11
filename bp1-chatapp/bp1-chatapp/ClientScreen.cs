using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bp1_chatapp
{
    public partial class ClientScreen : Form
    {
        private TcpClient _client;
        private NetworkStream _networkStream;

        public ClientScreen()
        {
            InitializeComponent();

            disconnectButton.Visible = false;
        }

        private async void ConnectServer(String ip, Int32 port, int bufferSize)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);

                _networkStream = _client.GetStream();

                await Task.Run(async () =>
                {
                    byte[] buffer = new byte[bufferSize];

                    while (_networkStream.CanRead)
                    {
                        int bytes = await _networkStream.ReadAsync(buffer, 0, bufferSize);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                        chatBox.Items.Add(message);
                    }
                });
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException Client: {0}",e);
            }
            finally
            {
                _client.Close();
            }
        }

        private void SendMessage(String data)
        {
            if (!_networkStream.CanWrite) return;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            _networkStream.Write(msg, 0, msg.Length);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            usernameInput.Enabled = false;
            bufferSizeInput.Enabled = false;
            connectButton.Visible = false;

            if (int.TryParse(portInput.Text, out var port))
            {
                ConnectServer(ipInput.Text, port, 256);
            }
            else
            {
                Console.WriteLine("Client: Port or buffersize not a number");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage(messagesInput.Text);
        }
    }
}