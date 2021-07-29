using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW1
{
    public class Starter
    {
        public void Run()
        {
            var myList = GetList();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(myList.Count);
        }

        private IReadOnlyCollection<int> GetList()
        {
            var defaultQuentity = 5;
            var myArr = new int[defaultQuentity];
            var defList = new List<int> { 123, 456, 789 };
            var myList = new MyList<int> { 1, 2, 3, 4, 5 };

            for (var i = 0; i < defaultQuentity; i++)
            {
                myList.Add(i + 1);
                myArr[i] = i + 10;
            }

            myList.AddRange(myArr);
            myList.AddRange(defList);
            myList.Remove(5);
            myList.Remove(2);
            myList.Remove(3);
            myList.RemoveEmptiness();
            myList.Sort();
            return myList;
        }
    }
}
