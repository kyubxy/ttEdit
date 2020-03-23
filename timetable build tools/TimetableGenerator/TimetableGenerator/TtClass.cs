using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableGenerator
{
    public class TtClass
    {
        public int line;
        public string subject;
        public string room;
        public int[] colour = { 0, 0, 0 };

        public TtClass(int l, string s, string r, int[] c)
        {
            line = l;
            subject = s;
            room = r;
            colour = c;
        }
    }
}
