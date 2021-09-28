using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_a_
{
    public interface Observer
    {
        
        void update(Ads ads);
        List<Ads> interest();
        string display();
    }
}
