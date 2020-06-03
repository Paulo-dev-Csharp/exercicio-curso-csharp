using ExercicioUml.Entities;
using System;
using ExercicioUml.Entities.Enums;
using System.Globalization;

namespace ExercicioUml {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("\n=-=-=-=-=-=-=Olar=-=-=-=-=-");
            Console.Write("Digite o nome do departamento: ");
            string departamento = Console.ReadLine();

            Console.WriteLine("Digite os dados do trabalhador");
            Console.Write("Digite Nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite o Level (Junior, Midlevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Digite o salario base: ");
            double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(departamento);
            Worker wk = new Worker(name, level, salario, dept);


            Console.WriteLine("Digite a quantidade de contratos: ");
            int contrato = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < contrato; a++) {

                Console.WriteLine("Vamos informar os dados do " + a + "º colaborador:");

                Console.Write("Digite a data: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Digite o valor de Horas: ");
                int hour = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o tempo de duração: ");
                int valuePerHour = Convert.ToInt32(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                wk.AddContract(contract);

                Console.WriteLine();

            }

            Console.WriteLine();
            Console.Write("\nDigite o mes/ano para realizar o calculo: ");
            string periodo = Console.ReadLine();

            int month = int.Parse(periodo.Substring(0, 2));
            int year = int.Parse(periodo.Substring(3));

            Console.WriteLine("Nome do trabalhador: " + wk.Name);
            Console.WriteLine("Departamento: " + wk.Department.Name);
            Console.WriteLine("Renda do período: "+ periodo + ": "+ wk.Income(year,month ), CultureInfo.InvariantCulture);



        }
    }
}
