using System;
using System.Reflection;
using ds168;
namespace mycalc
{
   
    class Calculator
    {
        public static void Main(String[] args)
        {


            Assembly myassembly = Assembly.LoadFrom("Calc.dll");//load the file

            foreach (Type classType in myassembly.GetTypes())//for each class type
            {
					Console.WriteLine("Class Name: "+classType.Name);
					Console.WriteLine("Constructor Info: ");
					foreach (ConstructorInfo consInfo in classType.GetConstructors())//for each constructor in a class
                    {
                        Console.WriteLine(consInfo.ToString());
                    }
					
					Console.WriteLine("Method Info: ");
				    foreach (MethodInfo methodInfo in classType.GetMethods())//for each method in a class
					{
						Console.WriteLine(methodInfo.GetBaseDefinition());
					}
			}		
				Start:
				Console.WriteLine("Choose your Calculator: Enter 1.Simple Calculator or Enter 2.Complex Calculator");
				String Calculator=Console.ReadLine();
				if(Calculator=="1"){
					Console.WriteLine("1.Simple Calculator");
					object[] arr = new object[2];
					Console.WriteLine("Enter Number1 :");
					arr[0] = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter Number2 :");
					arr[1] = int.Parse(Console.ReadLine());
					Console.WriteLine("What Calculation Do you want to Perform: ");
					Console.WriteLine("1.Enter '+' to perform Addition ");
					Console.WriteLine("2.Enter '-' to perform Subtraction ");
					Console.WriteLine("3.Enter '*' to perform Multiplication ");
					Console.WriteLine("4.Enter '/' to perform Division ");
					Type simple = myassembly.GetType("ds168.SimpleCalc");
				    object obj = Activator.CreateInstance(simple,arr);
					
					
					String caseSwitch =Console.ReadLine();
					switch (caseSwitch)
					{
					case "+":
						MethodInfo add = simple.GetMethod("Addition");
						Console.WriteLine("Addition :  "+add.Invoke(obj,null));
						break;
					case "-":
						MethodInfo sub = simple.GetMethod("Subtraction");
						Console.WriteLine("Subtraction :  "+sub.Invoke(obj,null));
						break;
					case "*":
						MethodInfo mul = simple.GetMethod("Multiplication");
						Console.WriteLine("Multiplication :  "+mul.Invoke(obj,null));
						break;
					case "/":
						MethodInfo div = simple.GetMethod("Division");
						Console.WriteLine("Division :  "+div.Invoke(obj,null));
						break;
					default:
						Console.WriteLine("Invalid Input");
						break;
					}
					
				}else if(Calculator=="2"){
					Console.WriteLine("2.Complex Calculator");
					
					object[] arry = new object[4];
					Console.WriteLine("Enter Complex Number1 :");
					Console.WriteLine("Enter Real Part :");
					arry[0] = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter Imaginary Part :");
					arry[1] = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter Complex Number2 :");
					Console.WriteLine("Enter Real Part :");
					arry[2] = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter Imaginary Part :");
					arry[3] = int.Parse(Console.ReadLine());
					Console.WriteLine("What Calculation Do you want to Perform: ");
					Console.WriteLine("1.Enter '+' to perform Addition ");
					Console.WriteLine("2.Enter '-' to perform Subtraction ");
					Console.WriteLine("3.Enter '*' to perform Multiplication ");
					Console.WriteLine("4.Enter '/' to perform Division ");
					Type complex = myassembly.GetType("ds168.ComplexCalc");
				    object obj = Activator.CreateInstance(complex,arry);
					String caseSwitch =Console.ReadLine();
					switch (caseSwitch)
					{
					case "+":
						MethodInfo addr = complex.GetMethod("realAddition");
						MethodInfo addi = complex.GetMethod("imgAddition");
						Console.WriteLine("Addition :  ("+addr.Invoke(obj,null)+")+i("+addi.Invoke(obj,null)+")");
						break;
					case "-":
						MethodInfo subr = complex.GetMethod("realSubtraction");
						MethodInfo subi = complex.GetMethod("imgSubtraction");
						Console.WriteLine("Subtraction :  ("+subr.Invoke(obj,null)+")+i("+subi.Invoke(obj,null)+")");
						break;
					case "*":
						MethodInfo mulr = complex.GetMethod("realMultiplication");
						MethodInfo muli = complex.GetMethod("imgMultiplication");
						Console.WriteLine("Multiplication :  ("+mulr.Invoke(obj,null)+")+i("+muli.Invoke(obj,null)+")");
						break;
					case "/":
						MethodInfo divr = complex.GetMethod("realDivision");
						MethodInfo divi = complex.GetMethod("imgDivision");
						Console.WriteLine("Division :  ("+divr.Invoke(obj,null)+")+i("+divi.Invoke(obj,null)+")");
						break;
					default:
						Console.WriteLine("Invalid Input");
						break;
					}
				}
				else{ 
					 Console.WriteLine("Invalid Input");
				}
			Console.WriteLine("Do you want to continue? 1.Yes 2.No");
            String str=Console.ReadLine();
			if (str=="1")
			goto Start;

        }
    }

}