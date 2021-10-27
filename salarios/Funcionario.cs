using System;
using System.Collections.Generic;
using System.Text;

namespace salarios
{
    class Funcionario
    {
        //encapsulamento.
       public  int Id { get; set; }
       public string Nome { get; set; }
       public  double Salario { get; set; }
        //construtor personalizado
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        //método aumento de salário.
        public void aumentarSalario(double X)
        {
            Salario = Salario + (Salario *( X / 100));
        }
    }
}
