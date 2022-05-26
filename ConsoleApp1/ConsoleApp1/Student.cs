using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int[] _grades;
        public int[] Grades

        {
            get
            {
                return _grades;
            }
            set
            {
                int[] evenarr = new int[0];
                int j = 0;
                
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        Array.Resize(ref evenarr, evenarr.Length + 1);
                        evenarr[j] = value[i];
                        j++;
                    }
                }
                if (evenarr.Length>0)
                {
                    _grades = evenarr;
                }
                else
                {
                    _grades = new int[] { 0 };
                }
                }
            }
        }
    }






