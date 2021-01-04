using System;
using System.Globalization;
using System.Collections.Generic;
namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Retangulo ret = new Retangulo();
             Console.WriteLine("Entre com a largura e altura do retângulo: ");

             ret.Largura = double.Parse(Console.ReadLine());
             ret.Altura = double.Parse(Console.ReadLine());
             Console.WriteLine("Area = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));*/

            /*            Funcionario f = new Funcionario();
                        Console.Write("Nome: ");
                        f.Nome = Console.ReadLine();
                        Console.Write("Salário Bruto: ");
                        f.SalarioBruto = double.Parse(Console.ReadLine());
                        Console.Write("Imposto: ");
                        f.Imposto = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Funcionario: " + f);

                        Console.Write("Digite a porcentagem para aumentar o salário: ");
                        f.AumentarSalario(double.Parse(Console.ReadLine()));
                        Console.WriteLine();
                        Console.WriteLine("Dados atualizados: " + f);*/
            /*
                        Aluno aluno = new Aluno();
                        Console.Write("Nome do aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Digite as três notas do aluno: ");
                        aluno.Nota1 = double.Parse(Console.ReadLine());
                        aluno.Nota2 = double.Parse(Console.ReadLine());
                        aluno.Nota3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

                        if (aluno.Aprovado())
                        {
                            Console.WriteLine("APROVADO");
                        }
                        else
                        {
                            Console.WriteLine("REPROVADO");
                            Console.WriteLine("FALTARAM "
                            + aluno.Resto().ToString("F2", CultureInfo.InvariantCulture)
                            + " PONTOS");
                        }*/
            /*
                        Console.Write("Qual é a cotação do dólar? ");
                        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Quantos dolares você vai comprar? ");
                        double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double resultado = ConversorDeMoeda.Conversao(quantidade, cotacao);

                        Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));*/

            /*  Estudante[] estudantes = new Estudante[10];
              Console.Write("Quantos quartos serão alugados? ");
              int n = int.Parse(Console.ReadLine());
              Console.WriteLine();

              for (int i = 1; i <= n; i++)
              {
                  Console.WriteLine("Aluguel #{0}:",i);
                  Console.Write("Nome: ");
                  string nome = Console.ReadLine();
                  Console.Write("Email: ");
                  string email = Console.ReadLine();
                  Console.Write("Quarto: ");
                  int quarto = int.Parse(Console.ReadLine());
                  estudantes[quarto] = new Estudante(nome, email);
              }
              Console.WriteLine();
              Console.WriteLine("Quartos ocupados: ");
              for (int i = 0; i < 10; i++)
              {
                  if(estudantes[i] != null)
                      Console.WriteLine(i + ": "+ estudantes[i]);
              }*/
            /*
                        List<Employee> employees = new List<Employee>();
                        Console.Write("How many employees will be registered? ");
                        int n = int.Parse(Console.ReadLine());
                        int id;
                        for (int i = 1; i <=n; i++)
                        {
                            Console.WriteLine("Employee #{0}:", i);
                            Console.Write("Id: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Name: ");
                            string nome = Console.ReadLine();
                            Console.Write("Salary: ");
                            double salary = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
                            employees.Add( new Employee(id, nome, salary));
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Enter the employee id that will have salary increase: ");
                        id = int.Parse(Console.ReadLine());
                        Employee emp = employees.Find(x => x.id == id);
                        if(emp != null)
                        {
                            Console.Write("Enter the percentage: ");
                            double percentage = double.Parse(Console.ReadLine());
                            emp.increaseSalary(percentage);
                        }
                        else
                        {
                            Console.WriteLine("This id does not exist!");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Updated list of employees:");
                        foreach (Employee obj in employees)
                        {
                            Console.WriteLine(obj);
                        }
                        */

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }

            }
            Console.WriteLine();
            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if(j > 0)
                            Console.WriteLine("Left: " + mat[i,j-1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i-1, j]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);

                    }
                        
                }
            }
            /* Console.WriteLine("Main diagonal");
             for (int i = 0; i < n; i++)
             {
                 Console.Write(mat[i, i] + " ");

             }
             Console.WriteLine();

             int count = 0;
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     if (mat[i, j] < 0)
                         count++;
                 }
             }
             Console.WriteLine("negative numbers: " + count);*/


        }
    }
}
