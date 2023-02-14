using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    public class TacoBel : ITrackable
    {
        public TacoBel()
        {

        }
        public string Name { get; set; }
        public Point Location { get; set; }
        
    }
}
