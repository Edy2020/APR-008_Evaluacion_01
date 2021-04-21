using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_01
{
    class Program
    {
        public class GlobalVariables
        {
            public static string[] students { get; set; } = new string[5];

            public static double[] score_01 { get; set; } = new double[4];
            public static double[] score_02 { get; set; } = new double[4];
            public static double[] score_03 { get; set; } = new double[4];
            public static double[] score_04 { get; set; } = new double[4];
            public static double[] score_05 { get; set; } = new double[4];
        }



        static void Main(string[] args)
        {
            bool enter_menu = true;

            do
            {
                int optionMenu = PrintMenu();

                switch (optionMenu)
                {
                    case 1:
                        Console.Clear(); //Ingresar Estudiantes
                        string[] ShowStudents = RequestStudens();
                        Console.WriteLine("============================================");
                        Console.WriteLine("    Estudiantes ingresados exitosamente");
                        Console.WriteLine("============================================");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear(); //Ingresar Notas
                        RequestScore();
                        Console.WriteLine("============================================");
                        Console.WriteLine("      Notas ingresadas exitosamente");
                        Console.WriteLine("============================================");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear(); //Mostrar Promedio
                        Console.WriteLine("============================================");
                        Console.WriteLine("1.- {0}", GlobalVariables.students);
                        Console.WriteLine("Promedio alumno: " + RequestAverage(GlobalVariables.score_01));
                        Console.WriteLine("============================================");
                        Console.WriteLine("2.- {1}", GlobalVariables.students);
                        Console.WriteLine("Promedio alumno: " + RequestAverage(GlobalVariables.score_02));
                        Console.WriteLine("============================================");
                        Console.WriteLine("3.- {2}", GlobalVariables.students);
                        Console.WriteLine("Promedio alumno: " + RequestAverage(GlobalVariables.score_03));
                        Console.WriteLine("============================================");
                        Console.WriteLine("4.- {3}", GlobalVariables.students);
                        Console.WriteLine("Promedio alumno: " + RequestAverage(GlobalVariables.score_04));
                        Console.WriteLine("============================================");
                        Console.WriteLine("5.- {4}", GlobalVariables.students);
                        Console.WriteLine("Promedio alumno: " + RequestAverage(GlobalVariables.score_05));
                        Console.WriteLine("============================================");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        GetStudents();
                        break;

                    case 5:
                        Console.Clear();
                        GetPoints();
                        break;
                        
                    case 6:
                        Console.Clear();
                        enter_menu = false;
                        Console.WriteLine("============================================");
                        Console.WriteLine("              Programa fuera...");
                        Console.WriteLine("============================================");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("============================================");
                        Console.WriteLine("                 E R R O R");
                        Console.WriteLine("============================================");
                        Console.ReadKey();
                        break;
                }
            }
            while (enter_menu);
            Console.ReadKey();
        }
        private static int PrintMenu() //MENU PRINCIPAL
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("============================================");
            Console.WriteLine("");
            Console.WriteLine("               Elija operacíon");
            Console.WriteLine("");
            Console.WriteLine("============================================");
            Console.WriteLine("1.- Ingresar alumnos   / 2.- Ingresar notas");
            Console.WriteLine("3.- Consultar promedio / 4.- Mostrar alumnos");
            Console.WriteLine("5.- Mostar Notas       / 6.- Salir");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            int optionMenu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return optionMenu;
        }
        private static string[] RequestStudens() //INGRESAR ESTUDIANTES
        {
            Console.WriteLine("============================================");
            Console.WriteLine("         Ingrese los estudiantes: ");
            Console.WriteLine("============================================");
            for (int i = 0; i < 5; i++)
            {
                GlobalVariables.students[i] = Console.ReadLine();
            }
            return GlobalVariables.students;
        }
        private static void RequestScore() //NOTAS
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("      Ingrese nota del primer alumno: ");
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                GlobalVariables.score_01[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("      Ingrese nota del segundo alumno: ");
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                GlobalVariables.score_02[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("      Ingrese nota del tercer alumno: ");
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                GlobalVariables.score_03[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("      Ingrese nota del cuarto alumno: "); 
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                GlobalVariables.score_04[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("      Ingrese nota del quinto alumno: ");
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                GlobalVariables.score_05[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        private static double RequestAverage(double[] score) //PROMEDIO
        {
            double[] ratings = score;
            double sum = 0;
            foreach (double rating in ratings)
            {
                sum += rating;
            }
            double average = sum / ratings.Length;
            return average;
            
        }

        private static void GetStudents() //MOSTRAR ESTUDIANTES
        {
            Console.WriteLine("============================================");
            Console.WriteLine("            Los estudiantes son: ");
            Console.WriteLine("============================================");
            Console.WriteLine("1.- {0}", GlobalVariables.students);
            Console.WriteLine("2.- {1}", GlobalVariables.students);
            Console.WriteLine("3.- {2}", GlobalVariables.students);
            Console.WriteLine("4.- {3}", GlobalVariables.students);
            Console.WriteLine("5.- {4}", GlobalVariables.students);
            Console.ReadKey();
        }

        private static void GetPoints() //MOSTRAR ESTUDIANTES + NOTAS
        {
            Console.WriteLine("============================================");
            Console.WriteLine("          Los estudiantes + Notas: ");
            Console.WriteLine("============================================");
            Console.WriteLine("1.- {0}", GlobalVariables.students);
            Console.WriteLine("    Notas: {0}", string.Join(", ", GlobalVariables.score_01));
            Console.WriteLine("============================================");
            Console.WriteLine("2.- {1}", GlobalVariables.students);
            Console.WriteLine("    Notas: {0}", string.Join(", ", GlobalVariables.score_02));
            Console.WriteLine("============================================");
            Console.WriteLine("3.- {2}", GlobalVariables.students);
            Console.WriteLine("    Notas: {0}", string.Join(", ", GlobalVariables.score_03));
            Console.WriteLine("============================================");
            Console.WriteLine("4.- {3}", GlobalVariables.students);
            Console.WriteLine("    Notas: {0}", string.Join(", ", GlobalVariables.score_04));
            Console.WriteLine("============================================");
            Console.WriteLine("5.- {4}", GlobalVariables.students);
            Console.WriteLine("    Notas: {0}", string.Join(", ", GlobalVariables.score_05));
            Console.WriteLine("============================================");
            Console.ReadKey();
        }


    }
}