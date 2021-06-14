using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicore.Services.Dtos
{
    public class UnicoreInfoVM
    {
        public int ID { get; set; }
        public int OwnerId { get; set; }
        public string UnicoreName { get; set; }
        public string UnicoreDescription { get; set; }
        public string OwnerName { get; set; }
        public string Mobile { get; set; }
    }
}
