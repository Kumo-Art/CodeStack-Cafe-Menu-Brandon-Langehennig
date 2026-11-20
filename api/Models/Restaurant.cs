using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Restaurant : BaseEntity
    {
        public string TagLine {get;set;} = string.Empty;

        public string Adrress {get;set;} = string.Empty;

        public string Hours {get;set;} = string.Empty;

        public string Phone {get;set;} = string.Empty;
    }
}