namespace projectApiCore.Interfaces
{
    public interface IMessegesRepository
    {
        IEnumerable<string> GetMessages(int workedId);
        void SendMessage(string msg, int workdId);
    }
}
