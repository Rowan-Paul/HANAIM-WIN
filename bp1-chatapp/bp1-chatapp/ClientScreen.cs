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
        }

        private async void ConnectServer(String ip, Int32 port)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);

                _networkStream = _client.GetStream();

                await Task.Run(async () =>
                {
                    byte[] buffer = new byte[1024];
                    NetworkStream networkStream = _client.GetStream();

                    while (networkStream.CanRead)
                    {
                        int bytes = await networkStream.ReadAsync(buffer, 0, 256);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                        Console.WriteLine("Server received: {0}", message);
                        chatBox.Items.Add(message);
                    }

                    networkStream.Close();
                });
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                _client.Close();
            }
        }

        private void sendMessage(String data)
        {
            if (!_networkStream.CanWrite) return;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            _networkStream.Write(msg, 0, msg.Length);

            Console.WriteLine("Client sent: {0}", data);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            usernameInput.Enabled = false;
            connectButton.Text = "Disconnect";

            ConnectServer(ipInput.Text, 3000);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessage(messagesInput.Text);
        }
    }
}