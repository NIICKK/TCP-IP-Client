using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ClientTestVision2
{
    public partial class Form1 : Form
    {
        //string strSend = "";
        string server = "10.1.12.224";
        string message = "You're so funny!";
        NetworkStream stream;
        Byte[] data;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Connect(server, message);
        }

        private void ReSend_Click(object sender, EventArgs e)
        {
            WriteInfo(stream, data);
            ReadInfo(stream, data);
        }

        private void WriteInfo(NetworkStream stream, Byte[] data)
        { 
            stream.Write(data, 0, data.Length);
            SendInfo.AppendText(DateTime.Now.ToString() + "\r\n");
            SendInfo.AppendText("Sent:" + message + "\r\n");
        }

        private void ReadInfo(NetworkStream stream, Byte[] data)
        {
            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            recInfo.AppendText(DateTime.Now.ToString() + "\r\n");
            recInfo.AppendText("Received: " + responseData + "\r\n");
            // Close everything.
        }

        private void Connect(String server, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 8000;
                TcpClient client = new TcpClient(server, port);
                // Translate the passed message into ASCII and store it as a Byte array.
                this.data = System.Text.Encoding.ASCII.GetBytes(message);
                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();
                this.stream = client.GetStream();

                // Send the message to the connected TcpServer.
                WriteInfo(stream, data);
                // Receive the TcpServer.response.
                ReadInfo(stream, data);

                // Close everything.
                //stream.Close();
                //client.Close();
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("ArgumentNullException: {0}", e.ToString());
            }
            catch (SocketException e)
            {
                MessageBox.Show("SocketException: {0}", e.ToString());
            }

            //Console.WriteLine("\n Press Enter to continue...");
            //Console.Read();
        }

    }
}
