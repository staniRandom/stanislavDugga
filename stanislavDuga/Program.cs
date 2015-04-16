using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stanislavDuga
{
   public class Program
    {
        static void Main(string[] args)
        {
            throw new NotImplementedException();
        }
        public long truoNumber(string s)
        {
            long newNuber = 0;
            bool started= false;
            bool ending= false;
            if (s == null) return -1;
            foreach (var item in s)
            {
                if (Char.IsNumber(item))
                {
                    started = true;
                    newNuber *= 10;
                    newNuber += int.Parse(item.ToString());

                }
                else if (started==true&&ending==false)
                {
                    switch (item)
                    {
                        case 'k':
                            newNuber *= 1000;
                            break;
                        case'm':
                            break;
                        default:
                            return -1;
                            
                    }
                }
            }
            return newNuber;
            
        }
    }
}
