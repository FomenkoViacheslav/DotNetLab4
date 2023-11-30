using Client.ChatServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class ChatServerConnector : IChatServiceCallback
    {      
        private static ChatServerConnector Instance = null;
        private ChatServiceClient Client;
        private int UserId;
        private string Username;

        private ChatServerConnector()
        {
            Client = new ChatServiceClient(new System.ServiceModel.InstanceContext(this));
        }
        static ChatServerConnector()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
        }
        public static ChatServerConnector GetInstance()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
            return Instance;
        }

        internal static void Connect(string text)
        {
            Instance.Username = text; 
            Instance.UserId = Instance.Client.Connect(text);
        }
        public void SendMessageToServer(string message)
        {
            GetInstance().Client.SendMessage($"{Username}: {message}");
        }
        public void SendMessageToClient(string message)
        {
            (Application.OpenForms["Form1"] as Form1).listBox1.Items.Add(message);
        }

        public void UserConnected(string username)
        {
 
            (Application.OpenForms["Form1"] as Form1).listBox2.Items.Add(username);
        }

        public void UserDisconnected(string username)
        {
   

           
            (Application.OpenForms["Form1"] as Form1).listBox2.Items.Remove(username);
        }

    }
}
