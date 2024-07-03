using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public abstract class Employee
    {
        public int Empid { get; set; }

        public string EmpName { get; set; }

        public int Deptno { get; set; }

        public abstract void CalculateSalary(float basic, float allowances);

        

        public int CalculateIncentives(double amt)
        { 
        if (amt <= 0) return 0;
        else if (amt >10) return 100;
            else
            {
                return 0;
            }
        }

        


    }

    public class Manager : Employee
    {
        public override sealed void CalculateSalary(float basic, float allowances)
        {
            Console.WriteLine(basic + allowances);


        }

    }




   public class Clerk : Employee
    {
        public override void CalculateSalary(float basic, float allowances)
        {
            //throw new NotImplementedException();
            Console.WriteLine(basic);
        }



   
    }


    public class SalesMan : Employee
    {
        double sal;
        public int Incentives { get; set; }
        public override void CalculateSalary(float basic, float allowances)
        {
             sal = basic + allowances;
            //Console.WriteLine(sal);

        }

        double _totSalary;
        public double TotalSalary { get {

                _totSalary = sal + Incentives;
                return _totSalary; 
            } 
            
             
        }
    }



    public class Products
    {

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

    }


   

    public class FoodProducts:Products
    {

        public void SellProduct(SalesMan emp)
        {
            Console.WriteLine("Enter productid");
            this.ProdId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter qty");
            this.Qty= Convert.ToInt32(Console.ReadLine());
            if (ProdId>=1 && ProdId<=10)
            {
                Price = 10;

            }
            else
            {
                Price = 20;
            }

            double amt=Price* Qty;
            emp.Incentives=emp.CalculateIncentives(amt);
            Console.WriteLine($"Amount of Incentives(Rs) {emp.Incentives}");
            emp.CalculateSalary(10000, 2000);
            
            double salAmount=emp.TotalSalary;
            Console.WriteLine(salAmount);
        }
    
    
    }


    public class Category
    { 
    public int Categoryid { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


    }







}
