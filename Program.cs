using System;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите количество переменных(максимум 4): ");
            string variables = Console.ReadLine();
            double a = double.Parse(variables);
            double step = Math.Pow(2, a);
            string cknf = "";
            string cdnf = "";
            
            int[] mass = new int[16];
            
            int[,] mass1 =  {
                                {0,0,1,1}, 
                                {0,1,0,1}
                            };

            int[,] mass2 =  {   
                                {0,0,0,0,1,1,1,1},
                                {0,0,1,1,0,0,1,1}, 
                                {0,1,0,1,0,1,0,1}
                            };

            int[,] mass3 =  {   
                                {0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1}, 
                                {0,0,0,0,1,1,1,1,0,0,0,0,1,1,1,1}, 
                                {0,0,1,1,0,0,1,1,0,0,1,1,0,0,1,1}, 
                                {0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1}
                            };
            
            

            
            if (a==2){
                Console.WriteLine("Введите столбец значений функции:");
                for (int i=0; i<step; i++){
                    string z = Console.ReadLine();
                    mass[i] = int.Parse(z);
                }
                
                Console.WriteLine("x y f(x,y)");
                for (int i=0; i<mass1.GetLength(1); i++){
                    Console.WriteLine(mass1[0,i] + " " +mass1[1,i] + " " + mass[i] );
                    if (mass[i]==1){
                        switch(mass1[0,i]){
                            case 1:
                                cknf = cknf + " X&";
                                break;
                            case 0:
                                cknf = cknf + " ¬X&";
                                break;
                        }
                        switch(mass1[1,i]){
                            case 1:
                                cknf = cknf + "Y V";
                                break;
                            case 0:
                                cknf = cknf + "¬Y V";
                                break;
                        }

                    }
                    else{
                        switch(mass1[0,i]){
                            case 1:
                                cdnf = cdnf + " (XV";
                                break;
                            case 0:
                                cdnf = cdnf + " (¬XV";
                                break;
                        }
                        switch(mass1[1,i]){
                            case 1:
                                cdnf = cdnf + "Y) &";
                                break;
                            case 0:
                                cdnf = cdnf + "¬Y) &";
                                break;
                        }  
                        }
                    }
                Console.WriteLine("СКНФ =" + cknf.TrimEnd('V'));
                Console.WriteLine("СДНФ =" + cdnf.TrimEnd('&'));
            }

            if (a == 3){

                Console.WriteLine("Введите столбец значений функции:");
                for (int i=0; i<step; i++){
                    string z = Console.ReadLine();
                    mass[i] = int.Parse(z);
                }
                Console.WriteLine("x y z f(x,y,z)");
                for (int i=0; i<mass2.GetLength(1); i++){
                    Console.WriteLine(mass2[0,i] + " " + mass2[1,i] + " " + mass2[2,i] + " "  + mass[i] );
                    if (mass[i]==1){
                        switch(mass2[0,i]){
                            case 1:
                                cknf = cknf + " X&";
                                break;
                            case 0:
                                cknf = cknf + " ¬X&";
                                break;
                        }
                        switch(mass2[1,i]){
                            case 1:
                                cknf = cknf + "Y&";
                                break;
                            case 0:
                                cknf = cknf + "¬Y&";
                                break;
                        }
                        switch(mass2[2,i]){
                            case 1:
                                cknf = cknf + "Z V";
                                break;
                            case 0:
                                cknf = cknf + "¬Z V";
                                break;
                        }

                    }
                    else{
                        switch(mass2[0,i]){
                            case 1:
                                cdnf = cdnf + " (X V";
                                break;
                            case 0:
                                cdnf = cdnf + " (¬X V";
                                break;
                        }
                        switch(mass2[1,i]){
                            case 1:
                                cdnf = cdnf + "Y V";
                                break;
                            case 0:
                                cdnf = cdnf + "¬Y V";
                                break;
                        }
                        switch(mass2[2,i]){
                            case 1:
                                cdnf = cdnf + " Z) &";
                                break;
                            case 0:
                                cdnf = cdnf + " ¬Z) &";
                                break;
                        }  
                        }
                    }
                Console.WriteLine("СКНФ =" + cknf.TrimEnd('V'));
                Console.WriteLine("СДНФ =" + cdnf.TrimEnd('&'));  
                
            }

            if (a == 4){
                
                Console.WriteLine("Введите столбец значений функции:");
                for (int i=0; i<step; i++){
                    string z = Console.ReadLine();
                    mass[i] = int.Parse(z);
                }
                Console.WriteLine("x y z t f(x,y,z,t)");
                for (int i=0; i<mass3.GetLength(1); i++){
                    Console.WriteLine(mass3[0,i] + " " + mass3[1,i] + " " + mass3[2,i] + " " + mass3[3,i] + " " + mass[i]);
                    if (mass[i]==1){
                        switch(mass3[0,i]){
                            case 1:
                                cknf = cknf + " X&";
                                break;
                            case 0:
                                cknf = cknf + " ¬X&";
                                break;
                        }
                        switch(mass3[1,i]){
                            case 1:
                                cknf = cknf + "Y&";
                                break;
                            case 0:
                                cknf = cknf + "¬Y&";
                                break;
                        }
                        switch(mass3[2,i]){
                            case 1:
                                cknf = cknf + "Z&";
                                break;
                            case 0:
                                cknf = cknf + "¬Z&";
                                break;
                        }
                        switch(mass3[3,i]){
                            case 1:
                                cknf = cknf + "T V";
                                break;
                            case 0:
                                cknf = cknf + "¬T V";
                                break;
                        }

                    }
                    else{
                        switch(mass3[0,i]){
                            case 1:
                                cdnf = cdnf + " (X V";
                                break;
                            case 0:
                                cdnf = cdnf + " (¬X V";
                                break;
                        }
                        switch(mass3[1,i]){
                            case 1:
                                cdnf = cdnf + " Y V";
                                break;
                            case 0:
                                cdnf = cdnf + " ¬Y V";
                                break;
                        }
                        switch(mass3[2,i]){
                            case 1:
                                cdnf = cdnf + " Z V";
                                break;
                            case 0:
                                cdnf = cdnf + " ¬Z V";
                                break;
                        }
                        switch(mass3[3,i]){
                            case 1:
                                cdnf = cdnf + " T) &";
                                break;
                            case 0:
                                cdnf = cdnf + " ¬T) &";
                                break;
                        }  
                        }
                    }
                Console.WriteLine("СКНФ =" + cknf.TrimEnd('V'));
                Console.WriteLine("СДНФ =" + cdnf.TrimEnd('&'));  
                }
            
            Console.ReadKey();

        
   
    }
}
}
