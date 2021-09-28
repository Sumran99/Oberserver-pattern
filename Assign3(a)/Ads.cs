using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_a_
{
    public class Ads
    {
        private string _prodName;
        private string _category;
        private string _price;
        
        
        public string ProdName { get => _prodName; set => _prodName = value; }
        public string Category { get => _category; set => _category = value; }
        public string Price { get => _price; set => _price = value; }
        

        public Ads(string pName, string cat, string pr)
        {
            this.ProdName = pName;
            this.Category = cat;
            this.Price = pr;
        }
        
        
        
    }
}
