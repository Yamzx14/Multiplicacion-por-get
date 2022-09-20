using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicasion_get_y_set
{
    internal class multiplicaclass
    {
      
        private int Nu1;
        private int Nu2;

        public int N11 { get => Nu1; set => Nu1 = value; }
        public int N21 { get => Nu2; set => Nu2 = value; }

        public int multiplica()
        {
            return (Nu1 * Nu2);
        }
    }
}
