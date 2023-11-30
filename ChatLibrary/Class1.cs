using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceContract(CallbackContract = typeof(IChatServiceCallback))]
    public interface IChatService
    {
        [OperationContract]
        int Connect(string username);
        [OperationContract(IsOneWay = true)]
        void Disconnect(int id);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }

    [ServiceContract]
    public interface IChatServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendMessageToClient(string message);

        [OperationContract(IsOneWay = true)]
        void UserConnected(string username);

        [OperationContract(IsOneWay = true)]
        void UserDisconnected(string username);
    }

    public class ChatUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperationContext Context { get; set; }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        List<ChatUser> usersList = new List<ChatUser>();
        int nextUserId = 1;
        public int Connect(string username)
        {
            ChatUser newUser = new ChatUser()
            {
                Id = nextUserId++,
                Name = username,
                Context = OperationContext.Current,
            };
            usersList.Add(newUser);

            foreach (ChatUser connectedUser in usersList)
            {
                connectedUser.Context.GetCallbackChannel<IChatServiceCallback>().UserConnected(username);
            }

            return newUser.Id;
        }

        public void Disconnect(int id)
        {
            var disconnectedUser = usersList.FirstOrDefault(x => x.Id == id);
            if (disconnectedUser != null)
            {
                // Уведомите клиента о отключении пользователя
                foreach (ChatUser otherUser in usersList)
                {
                    otherUser.Context.GetCallbackChannel<IChatServiceCallback>().UserDisconnected(disconnectedUser.Name);
                }

                usersList.Remove(disconnectedUser);
            }
        }


        public void SendMessage(string message)
        {
            foreach (ChatUser user in usersList)
            {
                // Измените формат сообщения, чтобы включить имя пользователя
                user.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient($"{user.Name}: {message}");
            }

        }
    }
}