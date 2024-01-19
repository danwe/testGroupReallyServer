using projectApiCore.Interfaces;

namespace projectApiCore.Repository
{
    public class MessegesRepository: IMessegesRepository
    {
      

        IEnumerable<string> IMessegesRepository.GetMessages(int workedId)
        {
            List<string> list = new List<string>();
            return list;
        }

      

        void IMessegesRepository.SendMessage(string msg, int workdId)
        {
            //service send msg and workid
        }
    }
}
