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
                if (Char.IsNumber(item)&&ending==false)
                {
                    started = true;
                    newNuber *= 10;
                    newNuber += int.Parse(item.ToString());

                }
                else if (started==true&&ending==false)
                {
                    char i = Char.ToLower(item);
                    switch (i)
                    {
                        case 'k':
                            newNuber *= 1000;
                            break;
                        case'm':
                            newNuber *= 1000000;
                            break;
                        case 'b':
                            newNuber *= 1000000000;
                            break;
                        case 't':
                            newNuber *= 1000000000000;
                            break;
                        default:
                            return -1;
                            
                    }
                    ending = true;
                }
                else
                {
                    return -1;
                }
            }
            return newNuber;
            
        }
    }
}
