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
        private TcpListener _tcpListener;
        private List<TcpClient> clientsConnected = new List<TcpClient>();
        
        public ServerScreen()
        {
            InitializeComponent();
        }

        private async void CreateServer(String ip, Int32 port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ip), port);
                _tcpListener.Start();
            
                while (true)
                {
                    _client = await _tcpListener.AcceptTcpClientAsync();

                    clientsConnected.Add(_client);
                    await Task.Run(() => MessageReceiver(_client));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        private async void MessageReceiver(TcpClient client)
        {
            try
            {
                byte[] buffer = new byte[256];
                NetworkStream networkStream = client.GetStream();

                while (networkStream.CanRead)
                {
                    int bytes = await networkStream.ReadAsync(buffer, 0, 256);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytes);

                    Console.Write("Server received: {0}",message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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