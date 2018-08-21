using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPoint.Class1
{
    //一列数的规则如下: 1、1、2、3、5、8、13、21、34......  求第30位数是多少， 用递归算法实现
    class digui
    {
        public int Digui(int i)
        {
            if (i == 0)
            {
                return (0);
            }
            else if (i <= 2)
            {
                return (1);
            }
            else
            {
                return Digui(i - 1) + Digui(i - 2);
            }
        }
    }
}
