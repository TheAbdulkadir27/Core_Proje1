using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IUserMessageService : IGenericService<UserMessage>
    {
        public List<UserMessage> GetUserMessagesWithUserService();
    }
}
