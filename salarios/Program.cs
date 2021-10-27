using System;

namespace salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis (diferente é igual o número total de ID diferentes.)
            int diferente = 0;
            //Recebendo quanto funcionários vão ser registrados.
            Console.WriteLine("Quantos funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());
            //Criando um vetor funcioário com o número informado.
            Funcionario[] vect = new Funcionario[n];
            //Looping passando a na quantidade de funcionários + coletando os dados, id, nome e salário.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionario #{i}");
                Console.WriteLine("Id: ");
                int id_fun = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome_fun = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                //Adicionando os dados ao vetor correspondente.
                vect[i - 1] = new Funcionario(id_fun, nome_fun, salario);
            }
            //Coletando qual ID ira receber o aumento.
            Console.WriteLine("ID do funcionário que receberá aumento: ");
            int funcionaroAumento = int.Parse(Console.ReadLine());
            //Teste para saber se existe o ID correspondido ou não.
            for(int i = 0; i < n; i++)
            {   //A caso exista, colocque a porcentagem de aumento e ele ira fazer a conta automaticamente.
                if (funcionaroAumento == vect[i].Id)
                {
                    Console.WriteLine("Porcentagem de aumento: (não coloque o caractere %) ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    vect[i].aumentarSalario(porcentagem);
                    Console.WriteLine();
                    Console.WriteLine(vect[i].Id + ", " + vect[i].Nome + ", " + vect[i].Salario.ToString("F2"));
                }
                //Caso não exista, ele ira informar os funcionarios que existem agora.
                else
                {
                    diferente = diferente + 1;
                    if (diferente == n  && funcionaroAumento != vect[i].Id)
                    {
                        Console.WriteLine("Este funcionário não existe!");
                        Console.WriteLine("Lista atualizada de funcionários:");
                        for (int o = 0; o < n; o++)
                        {
                            Console.WriteLine(vect[o].Id + ", " + vect[o].Nome + ", " + vect[o].Salario.ToString("F2"));
                        }
                    }
                }
            }
        }
    }
}
