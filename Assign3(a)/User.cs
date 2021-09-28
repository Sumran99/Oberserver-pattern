using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_a_
{
    class User: Observer
    {
        
        private String _name;
        private String _phoneNumber;
        private String _location;
        private List<String> _categories;
        private List<Ads> ads;

        public User(string name, string mobile, string loc, List<String> cat)
        {
            this.Name = name;
            this.PhoneNumber = mobile;
            this.Location = loc;
            this.Categories = cat;
            ads = new List<Ads>();
        }

        
        public string Name { get => _name; set => _name = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public List<string> Categories { get => _categories; set => _categories = value; }
        public string Location { get => _location; set => _location = value; }

        public void update(Ads obj)
        {
            foreach(string ad in Categories)
            {
                if(obj.Category == ad)
                {
                    ads.Add(obj);
                }
            }
             // if(Categories.Contains(obj.Category))
                
        }
        public List<Ads> interest()
        {
            return ads;

        }
        public string display()
        {
            string info = "";
            info += "Name: " + Name + "\n";
            info += "Category: ";
            foreach (String cat in Categories)
            {
                info += cat + " ";
            }
            info += "\n" + "Contact No: " + PhoneNumber + "\n" + "Location: " + Location + "\n";
            return info;
            

            
        }
    }
}
