using System;
using System.Collections.Generic;
using System.Text;
using Unicore.Services.Dtos;
using Unicore.Services.Entities;

namespace Unicore.Services.Extentions
{
    public static class Converter
    {
        public static UnicoreFarm ToEntity(this UnicoreInfoVM data) {
            return new UnicoreFarm
            {
                Id = data.ID,
                UnicoreName = data.UnicoreName,
                Description = data.UnicoreDescription,
                OwnerId = data.OwnerId,
                PurchesDate = DateTime.Now
            };
        }
    }
}
