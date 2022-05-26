using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tapsiriq:
            // Student classiniz olsun. int[] Grades propertysi olsun. 
            // Studentden obyekt yaradib grades-i set edende arrayin yanliz cut ededlerinden ibaret yeni bir array set olunsun. 
            //Yeni eger menStudent st = new Student();         
            //st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }
            //yaziramsa st.Grades { 2,4,6,8}-e beraber olsun 

            Student st = new Student();
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in st.Grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
