using System;
using System.Collections.Generic;
using System.Text;

namespace Unicore.Services.Entities
{
    public class UnicoreFarm
    {
        public int Id { get; set; }
        public string UnicoreName { get; set; }
        public int OwnerId { get; set; }
        public DateTime PurchesDate { get; set; }
        public string Description { get; set; }

        public Owner Owner { get; set; }
    }
}
