using ExercicioUml.Entities;
using System;

namespace ExercicioUml {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n=-=-=-=-=-=-=Olar=-=-=-=-=-");
            Console.Write("Digite o nome do departamento: ");
            Department dp = new Department();
            dp.Name = Console.ReadLine();

            Console.WriteLine("Digite os dados do trabalhador");
            Console.Write("Digite Nome: ");
            Worker wk = new Worker();
            wk.Name = Console.ReadLine();

            Console.Write("Digite o Level (Junior, Midlevel, Senior): ");
            string txt = Console.ReadLine();

            if (txt == "junior") {
                wk.Level = Entities.Enums.WorkerLevel.Junior;
            } else if (txt == "midlevel") {
                wk.Level = Entities.Enums.WorkerLevel.Midlevel;
            } else if (txt == "senior") {
                wk.Level = Entities.Enums.WorkerLevel.Senior;
            }

            txt = wk.Level.ToString();

            Console.WriteLine("Digite o salario base: ");
            wk.BaseSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de contratos: ");
            int contrato = Convert.ToInt32(Console.ReadLine());
            int a;

        }
    }
}
