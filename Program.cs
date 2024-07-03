using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clerk mgr=new Clerk();
            //mgr.CalculateSalary(10000f, 2000f);

            SalesMan salesMan = new SalesMan();
            salesMan.Empid = 1;
            salesMan.EmpName = "Hari";
            salesMan.Deptno = 2;

            FoodProducts food=new FoodProducts();
            food.SellProduct(salesMan);

            

            Console.Read();
        }
    }
}
