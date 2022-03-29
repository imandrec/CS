using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DisplayingVariables
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
            //Displaying Variables in the Console
            int myInt = 555;
            double myDouble = 5.5;
            string myString = "Hello World";
            bool myBool = true;
            char myChar = 'A';

            //el segundo 5 de {0,5} significa que el espacio en el que quiero mostrar la variable debe tener 5 espacios 
            //-5 hara que los espacios vacios esten a la derecha es decir con el - se alineara a la izquierda
            Console.WriteLine("The value of myInt is {0,-5} and the value of myDouble is {1,5}", myInt, myDouble);
            //puedo usar WriteLine or Write, la diferencia es que el primero hara una nueva linea cada vez que lo use
            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble);
            */


            /*
            //Using Arithmetic operators
            int result = 2 + 3 * 2;
            Console.WriteLine("The result is {0}",result);
            Console.WriteLine("2.The result is" + result);

            int x = 7;
            x += 1;
            Console.WriteLine(x);

            int y = 7;
            y++; // esto tiempre adicionara uno - this is post fix 
            ++y; //this is pre fix 
            Console.WriteLine(x);
            
            int a = 5;
            int b = a++;
            Console.WriteLine("Value for a is:{0} and Value for b is{1}",a,b);
            //a = 6 b = 5
            
            int a = 5;
            int b = ++a;
            Console.WriteLine("Value for a is:{0} and Value for b is{1}", a, b);
            //a = 6 b = 6
            */


            /*
            //Bool
            bool myBool = 5 < 10; //True
            Console.WriteLine(myBool);

            int hoursWorked = 41;
            bool doesEmployeeGetOverTime = hoursWorked > 40;

            Console.WriteLine("Does employee get overtime? {0}", doesEmployeeGetOverTime);
            */


            /*
            //Char
            char myChar = '\''; //output: '
            Console.WriteLine(myChar);
            */

            /*
            //String
            string name1 = "cata";
            string name2 = "hari";
            bool igual = name1 == name2; // option 1
            bool dosigual = string.Equals(name1, name2); // option 2 - returns true or false
            int tresigual = string.Compare(name1, name2); // option 3 - returns an int: por eso se cambia el bool del comienzo por el int 
            Console.WriteLine("Names equal: {0}",igual);
            Console.WriteLine("{0} has {1} characters", name1,name1.Length);
            string first_char_name1 = name1.Substring(0,1); // prints c (indexDondeEmpieza,cuantosChar)
            Console.WriteLine(first_char_name1);

            string name = "Jesse";
            string name2 = "Bob";
            Console.WriteLine(name.CompareTo(name2)); // output is 1
            */


            /*
            //Convertir numeros
            int x = 5;
            double y = x;
            double myDouble = 5.5;
            int myInt = (int)myDouble;// casting es convertir - aqui de double a int 
            Console.WriteLine(myInt); //5
            */


            /*
            //Constant
            //A value of a constant cant change once is set 
            const int x = 5;
            x = 3;//A value of a constant cant change once is set 
            Console.WriteLine(x);

            //enum is a keyword that represents an enumeration
            enum DayOfWeek
        {
            SUNDAY ,
            MONDAY ,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }
            //the default value of this numbers will be 0,1,2,3... or i can set new values
            DayOfWeek today = DayOfWeek.FRIDAY;
            Console.WriteLine(today); // prints FRIDAY
            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday); // prints 5
            */


            /*
            //Read from console
            //Everything that we read from the console will always be readed as a string 
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("What is your lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hi there {0} {1}",name,lastname);

            //Parse is convert string to number
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number += 10;
            Console.WriteLine("The number you entered plus 10 is: {0}", number);
            */


            /*
            //Calculator suma
            Console.WriteLine("Enter a number");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            double number2 = double.Parse(Console.ReadLine());
            double result = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
            */


            /*
            //Minutos y horas
            Console.WriteLine("enter a number of minutes ");
            int numero = int.Parse(Console.ReadLine());
            int horas = numero / 60;
            int min = numero % 60;
            Console.WriteLine("{0} horas {1} minutos", horas, min);
            */


            /*
            //If statement 
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("you are old");
            }
            else if (age < 18)
            {
                Console.WriteLine("you are young");
            }
            else
            {
                Console.WriteLine("wow you are 18");
            }
            */


            /*
            //Switch
            Console.WriteLine("What year are you in?");
            int year = int.Parse(Console.ReadLine());
            switch (year)
            {
                case 1:
                    {
                        Console.WriteLine("Freshman");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Junior");
                        break;
                    }
                case 3:
                case 4: // esto quiere decir que si es caso 3 o 4 va a imprimir senior 
                    {
                        Console.WriteLine("Senior");
                        break;
                    }
                default: // this is like else  
                    {
                        Console.WriteLine("Invalid value");
                        break;
                    }
            */


            /*
            //Conditional and not operators
            //(condition) ? true : false
            int x = 5;
            int y = 20;
            int biggest = x > y ? x : y;
            Console.WriteLine(biggest); // prints 20

            int score = 95;
            Console.WriteLine((score>=60) ? "Pass" : "Fail"); // prints pass
            */


            /*
            //if and negation
            bool myBool = true;
            if(myBool) // esto significa by defatils true, es como decir myBool = true
            if(!myBool) // Esto es como negarla - ! hace lo opuestoa lo que este en parentesis !(a>5) es igual a a<5
            */


            /*
            //Exercise 
            Console.WriteLine("Enter your payment per hour");
            double payment = double.Parse(Console.ReadLine());
            if (payment > 49 || payment < 7.5)
            {
                Console.WriteLine("There is a mistake with the rate");
            }
            else
            {
                Console.WriteLine("Rate is valid");
            }
            */


            //Exercise
            /*
            Console.WriteLine("Enter the length of the lawn");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the width");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double price_per_week = 0;
            double time = 20;
            

            if (area < 400){           
                price_per_week = 25;
            }
                
            else if (area > 400 && area < 600){
                price_per_week = 35;
            }

            else if (area > 600){
                price_per_week = 50;
            }

            else{
                Console.WriteLine("Error");
            }
            double weekly = price_per_week;
            double weeks = price_per_week * time;
            Console.WriteLine("The weekly rate is: {0} \nThe total fee for 20 weeks is: {1}", weekly, weeks);
            */                          
                
        }
    }
}
