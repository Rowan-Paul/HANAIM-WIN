using System;
using System.Net;
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

        private async void ConnectServer(IPAddress ip, Int32 port, int bufferSize)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);

                _networkStream = _client.GetStream();
                chatBox.Items.Add("Connected to " + ip);

                await Task.Run(async () =>
                {
                    byte[] buffer = new byte[bufferSize];

                    do
                    {
                        int bytes = await _networkStream.ReadAsync(buffer, 0, bufferSize);
                        string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                        messagesInput.Text = "";
                        if (message.Length > 0)
                        {
                            chatBox.Items.Add(message);
                        }
                        else
                        {
                            throw new Exception("Server down");
                        }
                    } while (_networkStream.CanRead);
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("Client: {0}", e);
            }
            finally
            {
                chatBox.Items.Add("Disconnected");
                _client.Close();

                ipInput.Enabled = true;
                portInput.Enabled = true;
                usernameInput.Enabled = true;
                bufferSizeInput.Enabled = true;
                connectButton.Visible = true;
                disconnectButton.Visible = false;
            }
        }

        private void SendMessage(String data)
        {
            if (!_networkStream.CanWrite) return;
            byte[] msg = Encoding.ASCII.GetBytes(data);

            try
            {
                _networkStream.Write(msg, 0, msg.Length);
            }
            catch
            {
                chatBox.Items.Add("Server disconnected");
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            usernameInput.Enabled = false;
            bufferSizeInput.Enabled = false;
            connectButton.Visible = false;
            disconnectButton.Visible = true;

            //TODO: add max port, buffersize
            if (int.TryParse(portInput.Text, out var port) &&
                int.TryParse(bufferSizeInput.Text, out var bufferSize) &&
                IPAddress.TryParse(ipInput.Text, out IPAddress ip))
            {
                ConnectServer(ip, port, bufferSize);
            }
            else
            {
                chatBox.Items.Add("Client: Port or buffersize not a number");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage(messagesInput.Text);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                chatBox.Items.Add("Disconnected");
                _client.Close();
                
                ipInput.Enabled = true;
                portInput.Enabled = true;
                usernameInput.Enabled = true;
                bufferSizeInput.Enabled = true;
                connectButton.Visible = true;
                disconnectButton.Visible = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Client: {0}", exception);
            }
        }
    }
}