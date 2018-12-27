﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexTradingDatabase
{
    [Serializable]
   public class PortFolioData
    {
        public PortFolioData()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public TradingPair TradingPair { get; set; }

        public DateTime? DateOfBuy { get; set; }
        public DateTime? DateOfSold { get; set; }

        public User User { get; set; }

        public double Price { get; set; }
       
    }
}