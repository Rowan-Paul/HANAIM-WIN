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

                await Task.Run(MessageReceiver);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
        }

        private async void MessageReceiver()
        {
            byte[] buffer = new byte[1024];
            NetworkStream networkStream = _client.GetStream();

            while (networkStream.CanRead)
            {
                byte[] messageByteArray = Encoding.ASCII.GetBytes("Hi sjaak");
                await _networkStream.WriteAsync(messageByteArray, 0, messageByteArray.Length);

                int bytes = await networkStream.ReadAsync(buffer, 0, 1024);
                var message = Encoding.ASCII.GetString(buffer, 0, bytes);
    
                Console.WriteLine("Client received: {0}", message);
            }
      
            networkStream.Close();
            _client.Close();
        }
        
        private void connectButton_Click(object sender, EventArgs e)
        {
            ipInput.Enabled = false;
            portInput.Enabled = false;
            usernameInput.Enabled = false;
            connectButton.Text = "Disconnect";

            ConnectServer(ipInput.Text, 3000);
        }
    }
}