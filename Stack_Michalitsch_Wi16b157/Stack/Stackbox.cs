using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Michalitsch_Wi16b157
{
    class Stackbox<T>
    {
        
        public T Content { get; internal set; }
        public Stackbox<T> Below { get; set; }

        public Stackbox(Stackbox<T> box)
        {
            Content = box.Content;
            Below = box.Below;
        }

        public Stackbox()
        {
        }
    }

}
