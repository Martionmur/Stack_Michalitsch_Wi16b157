using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Michalitsch_Wi16b157
{
    class Stack<T>
    {
        public Stackbox<T> Top = new Stackbox<T>();

        /// <summary>
        /// Push mit String
        /// </summary>
        /// <param name="input"></param>
        public void Push (T input)
        {
            Stackbox<T> box = new Stackbox<T>
            {
                Content = input,
                Below = Top
            };
            Top = box;
        }

        /// <summary>
        /// pop ist simple delete laut angabe
        /// </summary>
        
        public T Pop()
        {
            if (Top.Below != null)
            {
                Stackbox<T> Dummy = new Stackbox<T>(Top);
                Top = Top.Below;
                return Dummy.Content;                
            }
            else
            {
                throw new NullReferenceException();
            }

        }

        /// <summary>
        /// Top als object ausgeben
        /// </summary>
        /// <returns></returns>
        public T peek()
        {
            /// Deepcopy???
            /// return new Stackbox<T>(Top);
            return Top.Content;
        }
      
        
        
    }
}
