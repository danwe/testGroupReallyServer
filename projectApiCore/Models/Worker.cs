
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace projectApiCore.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public Gender Gender { get; set; }
        public DepartmentType DepartmentType { get; set; }
        public WorkerTypeId WorkerTypeId { get; set; }
    }
}
