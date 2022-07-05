using System;
using Uppercasting.Models;

namespace Uppercasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //    int[] arr = { 1, 2, 3, 4, 5, 6 };
            //    GetElements(arr);
            //    GetElements(1, 2, 3, 4, 5);

            //}
            //public static void GetElements(params int[] nums)
            //{
            //    foreach (var item in nums)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion
            #region Enums
            //    public static void CheckRole(int roleId)
            //    {
            //        switch (roleId)
            //        {
            //            case (int)Roles.SuperAdmin:
            //                Console.WriteLine("SuperAdmin");
            //                break;
            //            case (int)Roles.Admin:
            //                Console.WriteLine("Admin");
            //                break;
            //            case (int)Roles.Member:
            //                Console.WriteLine("Member");
            //                break;
            //            default:
            //                Console.WriteLine("Not found");
            //                break;
            //        }
            //    }
            //}



            //public enum Roles
            //{
            //    SuperAdmin,
            //    Admin,
            //    Member

            //}
            #endregion
            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);
            //Console.WriteLine(test.Word);
            //string name = null;
            //int? age = null;

            //Console.WriteLine(age);

            //var result = age == null ? 55 : 60;
            //Console.WriteLine(result);
            //var result1 = name == null ? 10 : 60;
            //var result2 = age ?? 60;

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            //Test test = null;
            //Console.WriteLine(test.Word.ToString());


            //class Test
            //{
            //    public int Number { get; set; }
            //    public string Word { get; set; }
            //}
            #endregion
            #region Struct
            //    Test test = new Test("Eshgin");
            //    Console.WriteLine(test.Num);

            //    Test1 test1 = new Test1();

            //    struct Test
            //{
            //    public int Num { get; set; }
            //    public Test(string name)
            //    {
            //        Num = 66;
            //    }
            //}

            //class Test1
            //{
            //    public Test1(int num)
            //    {
            //        Console.WriteLine("He");
            //    }
            //    public Test1()
            //    {
            //        Console.WriteLine("");
            //    }
            //}

            //struct Test3
            //{

            //}

            //interface ITest
            //{

            //}
            #endregion
            #region Upcasting,Boxing,Implicit
            //byte m = 5;
            //int n = m;

            //Eagle eagle1 = new Eagle();
            //Eagle eagle3 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();


            //Animal eagle2 = eagle1;

            //Animal[] animals = { shark1, eagle1, eagle2, eagle3, shark2 };
            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}
            #endregion
            Shark shark1 = new Shark();
            Animal shark2 = new Shark();
            Shark shark3 = (Shark)shark2;
        }
    }
  
    
}   