using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnPoint.Class1;


namespace LearnPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //冒泡
            maopao maopao = new maopao(9); 
            foreach (int i in maopao.MaopaoFun())
            {
                Console.WriteLine(i);
            }
            #endregion

            //递归
            Console.WriteLine($"递归30为:{new digui().Digui(30)}");
            Console.ReadKey();
        }
    }
}

