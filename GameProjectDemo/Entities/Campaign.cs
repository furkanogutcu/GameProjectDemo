using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Campaign:ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
    }
}
