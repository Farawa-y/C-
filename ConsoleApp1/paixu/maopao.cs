using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.paixu
{
    class maopao
    {
        List<int> list = new List<int>();
        
        public maopao(int num)
        {
            for(int i = 0; i <= num; i++)
            {

                list.Add(new Random().Next());
            }
        }

        public void MaopaoFun()
        {
            for (int i = 0; i < (list.Count-1)*list.Count/2; i++)
            {
                for(int j = i; j <list.Count-i-1; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        int temp;
                        temp = j;
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }    
                }
            }
        }         
    }
}
