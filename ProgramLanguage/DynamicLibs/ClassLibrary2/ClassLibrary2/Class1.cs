using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    /// <summary>
    /// Генерация случайных чисел для получения порядка вывода ответов
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Метод генерации случайных чисел для получения порядка вывода ответов
        /// </summary>
        /// <param name="max"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] Rand(int max, int[] x)
        {       
            Random r = new Random();
            for (int i = 0; i < max; i++)
            {
                bool contains;
                int next;
                do
                {
                    next = r.Next(max);
                    contains = false;
                    for (int index = 0; index < i; index++)
                    {
                        int n = x[index];
                        if (n == next)
                        {
                            contains = true;
                            break;
                        }
                    }
                } while (contains);
                x[i] = next;
            }
            return x;
        }
    }
}
