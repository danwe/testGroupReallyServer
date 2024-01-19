using projectApiCore.Interfaces;
using projectApiCore.Models;
using System.Text.Json;

namespace projectApiCore.Repository
{
    public class OrganizationRepository :IOrganizationRepository
    {

        public List<Worker> GetWorkerList()
        {

           // var json = File.ReadAllText(@"c:\dev\worker.json");
            //  Root root = JsonSerializer.Deserialize<Root>(json);
            List<Worker> root = new List<Worker>();
            using (StreamReader r = new StreamReader(@"c:\dev\worker.json"))
            {
                string jsona = r.ReadToEnd();
                root = JsonSerializer.Deserialize<List<Worker>>(jsona);
            }
            return root;
        }
    }
}
