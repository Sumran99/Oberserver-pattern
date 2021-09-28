using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_a_
{
    public class Admin: Subject
    {
        public List<Observer> obs;
        
        public Admin()
        {
            obs = new List<Observer>();
            
        }
        public void registerObserver(Observer o)
        {
            obs.Add(o);

        }
        public void removeObserver(Observer o)
        {
            obs.Remove(o);
        }
        public void notifyObserver(Ads ads)
        {
            foreach(Observer i in obs)
            {
                i.update(ads);
            }
        }
    }
}
