using System.Linq;

namespace ChatFormDBLibrary
{
    public partial class Message
    {
        public User UserReceiver => ChatFormDB.GetAllUsers().FirstOrDefault(it => it.Id == IdReceiver);       
        public User UserSender => ChatFormDB.GetAllUsers().FirstOrDefault(it => it.Id == IdSender);
        public override string ToString() => $"{UserSender} отправил сообщение: {Text} {UserReceiver}";
    }
}
