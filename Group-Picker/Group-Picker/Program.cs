using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Picker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "Umar", "Keith", "Aaron", "Matt", "Mitch", "Kris", "David", "Nathan", "Ryan", "Colton", "Mac", "Lamond", "Mahmoud" };

            PickGroup(studentList, 4);

            Console.ReadKey();

        }

        private static void PickGroup(List<string> studentList, int groupSize)
        {
           
            List<string> currentGroupList = new List<string>();
            //will track how many new groups have been created
            int groupNumber = 1;
            //generates a random number
            Random rng = new Random();

            //loops through the entire list to pick a random student
            for (int i = studentList.Count - 1; i >= 0; i--)
            {
                //choose student randomly, add to new list and subtract from old list
                string currentStudent = studentList[rng.Next(0, i + 1)];
                currentGroupList.Add(currentStudent);
                studentList.Remove(currentStudent);

                //stop if studentList is done or new group is full
                if ((currentGroupList.Count == groupSize) || (studentList.Count == 0))
                {
                    //show us the groups on the schree
                    Console.WriteLine("GROUP {0}", groupNumber);
                    for (int j = 0; j < currentGroupList.Count; j++)
                    {
                        Console.WriteLine("{0}", currentGroupList[j]);
                    }
                   
                    Console.WriteLine();
                    
                    currentGroupList.Clear();
                    groupNumber++;
                }
            }
        }
    }
}
