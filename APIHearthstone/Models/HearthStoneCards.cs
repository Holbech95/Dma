using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HearthStoneCards 
    {
        
        public List<HearthStoneCard> Basic { get; set; }

        public List<HearthStoneCard> Classic { get; set; }

        public List<HearthStoneCard> Naxxramas { get; set; }

        public List<HearthStoneCard> GoblinsVsGnomes { get; set; }

        public List<HearthStoneCard> BlackrockMountain { get; set; }

    }
}
