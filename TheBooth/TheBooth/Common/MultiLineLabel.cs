using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheBooth.Common
{
    public class MultiLineLabel : Label
    {
        // Default number of lines is 1 so MultiLineLabel behaves like a standard Label if Lines is not set
        public int Lines = 3;
    }
}
