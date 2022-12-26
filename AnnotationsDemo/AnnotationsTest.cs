using AnnotationsDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine(" Employee class Validation ");
            Console.WriteLine("--------------------------\n");
            Employee employee = new Employee();
            employee.Name = "vali";
            employee.Age = 24;
            employee.PhoneNumber = "9966576672";
            employee.EmailID = "bashavali222@gmail.com";
            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :{0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name : " + employee.Name + "\n" + "Age : " + employee.Age + "\n" + "Phone Number : " + employee.PhoneNumber + "\n" + "Email ID : " + employee.EmailID);
            }
            Console.WriteLine("\nPress any key to Exit ");
            Console.ReadKey();
        }
    }
}
