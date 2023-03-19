using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentIds = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            studentIds.OrderBy(o => o);
            Console.ReadKey();
        }
    }
}
