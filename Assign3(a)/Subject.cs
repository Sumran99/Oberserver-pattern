using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_a_
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObserver(Ads ads);
    }
}
