using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPoint.Class1
{
    class maopao
    {

        public List<int> list = new List<int>();
        
        public maopao(int num)
        {
            for(int i = 0; i <= num; i++)
            {
                list.Add(new Random(100-i).Next(50));
            }
        }

        public  List<int> MaopaoFun()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j <list.Count-i-1; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        int temp;
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }    
                }
            }
            return list;
        }         
    }
}
