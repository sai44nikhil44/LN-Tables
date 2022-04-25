using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Tulpep.NotificationWindow;
namespace ChatBot
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            textLocalIP.Text = GetLocalIP();
            //textRemoteIP.Text = GetLocalIP();
            


        }



        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();   
                }
            }
            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                // connecting to remote
                epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epRemote);

                // connection status
                textStatus.Text = "Success";


                //Lisenting to specific port
                buffer = new byte[1500];

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }

            catch(Exception ex)
            {
                textStatus.Text = ex.ToString();
            }

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //convert message string to byte array

            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //sending Encoded Message
            sck.Send(sendingMessage);

            // adding message to list box
            listMessage.Items.Add("Me:" + textMessage.Text);
           /*
            if (WindowState == FormWindowState.Normal)
            {

                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "ChatBot message";
                popup.ContentText = "message sent to : " + epRemote;
                popup.Popup();


            }
           */

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                 WindowState = FormWindowState.Maximized;

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                // Converitng byte array to String

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this message into ListBox
                listMessage.Items.Add("Freind:" + receivedMessage);

                
                /*
                    
                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "ChatBot message";
                    popup.ContentText = "message from : " + epRemote + "\n" + receivedMessage;
                    popup.Popup();

                */



                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
          //  throw new NotImplementedException();
        }
    }
}
