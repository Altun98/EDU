using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public static class Tool
    {
        public static int Count = 0;
        public static int get_id()
        {
            return ++Count;
        }
    }
}
