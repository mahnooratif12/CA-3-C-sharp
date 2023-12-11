using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricDB.Shared
{
    public class APIResponse
    {
        public Team[]? list { get; set; }
        public AppIndex? appIndex {  get; set; } 
    }
}
