using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Homework in computer science from 09.07.2023
            Page 50 questions 9, 10, 11, 12, 13, 14*/
            // Answer to the ninth question:
            Console.WriteLine("Please, enter here the length of the altitude of an equilateral triangle:");
            double the_length_of_the_altitude_of_an_equilateral_triangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter here the length of the base of an equilateral triangle:");
            double the_length_of_the_base_of_an_equilateral_triangle = double.Parse(Console.ReadLine());
            double area_of_an_equilateral_triangle = (the_length_of_the_altitude_of_an_equilateral_triangle* the_length_of_the_base_of_an_equilateral_triangle) / 2;
            Console.WriteLine("S="+area_of_an_equilateral_triangle);
            double perimeter_of_an_equilateral_triangle = (3 * the_length_of_the_base_of_an_equilateral_triangle);
            Console.WriteLine("P="+ perimeter_of_an_equilateral_triangle);
            // Answer to the tenth question:
            Console.WriteLine("Please, Enter here the number of corks with a value of 10 in points:");
            int the_number_of_corks_with_a_value_of_10_in_points = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter here the number of corks with a value of 100 in points:");
            int the_number_of_corks_with_a_value_of_100_in_points = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter here the number of corks with a value of 1000 in points:");
            int the_number_of_corks_with_a_value_of_1000_in_points = int.Parse(Console.ReadLine());
            int the_total_value_of_points = (the_number_of_corks_with_a_value_of_10_in_points * 10) + (the_number_of_corks_with_a_value_of_100_in_points * 100) + (the_number_of_corks_with_a_value_of_1000_in_points * 1000);
            Console.WriteLine("The total value of points:"+the_total_value_of_points);
            // Answer to the eleventh question:
            Console.WriteLine("Enter the price of the trip in USD here please:");
            double the_price_of_the_trip_in_usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the USD rate here:");
            double usd_rate = double.Parse(Console.ReadLine());
            double the_total_price_of_the_trip_in_nis = ((the_price_of_the_trip_in_usd * usd_rate)+(400*usd_rate));
            Console.WriteLine("The total amount of the trip in nis is:"+the_total_price_of_the_trip_in_nis);
            // Answer to the twelfth question:
            Console.WriteLine("Enter the temperature in Fahrenheit degrees here please:");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (((double)5/9)*(fahrenheit-32));
            Console.WriteLine(fahrenheit + "°F=" + celsius + "°C");
            // Answer to the thirteenth question:
            Console.WriteLine("Enter the daily wage rate of the employee in USD here please:");
            double daily_wage_rate_of_the_employee_in_usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of hours the employee worked at the daily wage rate here please:");
            int the_number_of_hours_the_employee_worked_at_the_daily_wage_rate = int.Parse(Console.ReadLine());
            double the_employees_nightly_wage_rate_in_usd = (daily_wage_rate_of_the_employee_in_usd + (0.5 * daily_wage_rate_of_the_employee_in_usd));
            Console.WriteLine("Enter the number of hours the employee worked at the nightly wage rate here please:");
            int the_number_of_hours_the_employee_worked_at_the_nightly_wage_rate = int.Parse(Console.ReadLine());
            double the_employees_saturday_wage_rate_in_usd = (2 * daily_wage_rate_of_the_employee_in_usd);
            Console.WriteLine("Enter the number of hours the employee worked at the Saturday wage rate here please:");
            int the_number_of_hours_the_employee_worked_at_the_saturday_wage_rate = int.Parse(Console.ReadLine());
            double the_employees_daily_wage_in_usd = (daily_wage_rate_of_the_employee_in_usd * the_number_of_hours_the_employee_worked_at_the_daily_wage_rate);
            double the_employees_nigthy_wage_in_usd = (the_employees_nightly_wage_rate_in_usd * the_number_of_hours_the_employee_worked_at_the_nightly_wage_rate);
            double the_employees_sturday_wage_in_usd = (the_employees_saturday_wage_rate_in_usd * the_number_of_hours_the_employee_worked_at_the_saturday_wage_rate);
            double the_total_salary_of_the_employee_in_usd = the_employees_daily_wage_in_usd + the_employees_nigthy_wage_in_usd + the_employees_sturday_wage_in_usd;
            Console.WriteLine("The employee's total salary in USD is:"+ the_total_salary_of_the_employee_in_usd);
            // Answer to the fourteenth question:
            Console.WriteLine("Please enter your age here please:");
            int users_age = int.Parse(Console.ReadLine());
            int the_number_of_days_the_user_is_alive = (users_age * 365);
            Console.WriteLine("The number of days the user is alive is:"+ the_number_of_days_the_user_is_alive);
            int the_number_of_hours_the_user_is_alive = (users_age * 365 * 24);
            Console.WriteLine("The number of hours the user is alive is:" + the_number_of_hours_the_user_is_alive);
            int the_number_of_seconds_the_user_is_alive = (users_age * 365 * 24 * 60 * 60);
            Console.WriteLine("The number of seconds the user is alive is:" + the_number_of_seconds_the_user_is_alive);
            // Answer to the fifteenth question:
            /*ax+b=c*/
            Console.WriteLine("ax+b=c");
            Console.WriteLine("Please enter here the value of the a variable:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter here the value of the b variable:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter here the value of the c variable:");
            double c = double.Parse(Console.ReadLine());
            double d = c - b;
            double x_res;
            if (b == 0 && c == 0 && a != 0)
            {
                x_res = 0;
                Console.WriteLine("x=" + x_res);
            }
            else if (b != 0 && c != 0 && a != 0)
            {
                x_res = d / a;
                Console.WriteLine("x=" + x_res);
            }
            else if (b != 0 && c != 0 && a == 0)
            {
                Console.WriteLine("Cannot be divided by 0.");
            }
            else if (b == 0 && c == 0 && a == 0)
            {
                Console.WriteLine("The solution is not defined.");
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
