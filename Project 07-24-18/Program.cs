using System;

namespace Project_07_24_18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employee = new Employee[3];
            for(int i = 0; i < employee.Length; i++){
                employee[i] = new Employee();
            }

            employee[0].Id = 1;
            employee[0].FirstName = "Bob";
            employee[0].LastName = "Adams";
            employee[0].DOB = new DateTime(1985, 4, 8);
            employee[0].Department = "Marketing";
            employee[0].EmployeeId = 15234;
            employee[0].DOJ = new DateTime(2017, 1, 18);

            employee[1].Id = 2;
            employee[1].FirstName = "Xavier";
            employee[1].LastName = "Khan";
            employee[1].DOB = new DateTime(1985, 1, 12);
            employee[1].Department = "IT";
            employee[1].EmployeeId = 15235;
            employee[1].DOJ = new DateTime(2015, 1, 1);

            employee[2].Id = 3;
            employee[2].FirstName = "Ryan";
            employee[2].LastName = "Denver";
            employee[2].DOB = new DateTime(1988, 5, 3);
            employee[2].Department = "Finance";
            employee[2].EmployeeId = 15236;
            employee[2].DOJ = new DateTime(2013, 12, 4);
           
           Console.WriteLine("UNSORTED");
            printEmployeeValues(employee);

            sortEmployees(employee);
            Console.WriteLine("SORTED");
            printEmployeeValues(employee);

            Customer[] customer = new Customer[3];
            for(int i = 0; i < customer.Length; i++){
                customer[i] = new Customer();
            }

            customer[0].Id = 1;
            customer[0].FirstName = "George";
            customer[0].LastName = "Fanning";
            customer[0].DOB = new DateTime(1990, 2, 15);
            customer[0].Address = "ABC Street";
            customer[0].City = "Nowhere";
            customer[0].State = "NV";

            customer[1].Id = 2;
            customer[1].FirstName = "Alex";
            customer[1].LastName = "White";
            customer[1].DOB = new DateTime(1989, 1, 18);
            customer[1].Address = "123 Maple Dr";
            customer[1].City = "Houston";
            customer[1].State = "TX";

            customer[2].Id = 3;
            customer[2].FirstName = "Colonel";
            customer[2].LastName = "Mustard";
            customer[2].DOB = new DateTime(1975, 9, 6);
            customer[2].Address = "1122 Sunset Pkwy";
            customer[2].City = "Woodbridge";
            customer[2].State = "VA";

            Console.WriteLine("UNSORTED CUSTOMERS");
            printCustomerValues(customer);

            Console.WriteLine("SORTED CUSTOMERS");
            sortCustomers(customer);
            printCustomerValues(customer);

        }
        public static void printEmployeeValues(Employee[] e){
            for(int i = 0; i < e.Length; i++){
                Console.WriteLine($"{e[i].Id} {e[i].FirstName} {e[i].LastName} {e[i].DOB} {e[i].Department} {e[i].EmployeeId} {e[i].DOJ}");
            }
        }
        public static void sortEmployees(Employee[] e){
            //sort employees by first name
            for(int i = 0; i < e.Length; i++){
                for(int j = 0; j < e.Length-1; j++){
                    if (e[j].FirstName.CompareTo(e[j+1].FirstName) > 0){
                        swap(ref e[j], ref e[j+1]);
                    }
                }
            }
        }
        public static void swap(ref Employee x, ref Employee y){
            Employee temp = x;
            x = y;
            y = temp;
        }

        public static void printCustomerValues(Customer[] c){
            for(int i = 0; i < c.Length; i++){
                Console.WriteLine($"{c[i].Id} {c[i].FirstName} {c[i].LastName} {c[i].DOB} {c[i].Address} {c[i].City} {c[i].State}");
            }
        }
        public static void sortCustomers(Customer[] c){
            //sort customers by first name
            for(int i = 0; i < c.Length; i++){
                for(int j = 0; j < c.Length-1; j++){
                    if (c[j].FirstName.CompareTo(c[j+1].FirstName) > 0){
                        swapCustomer(ref c[j], ref c[j+1]);
                    }
                }
            }
        }
        public static void swapCustomer(ref Customer x, ref Customer y){
            Customer temp = x;
            x = y;
            y = temp;
        }
    }
}
