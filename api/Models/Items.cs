using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace api.Models
{
    public class Items : BaseEntity
    {
        public int Category {get;set;}

        public int Price {get;set;}

        public string Description {get;set;} = string.Empty;

        public string Image {get;set;} = string.Empty;

        public string Tag {get;set;} = string.Empty;
    }
}