using System;
using System.Globalization;

namespace interessantesaberdecsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva " +
                "0 Para sair\n" +
                "1 Para expreções condicionáis \n" +
                "2 Funções para string \n" +
                "3 pára operacoes com data\n" +
                "");
            int oque = int.Parse(Console.ReadLine());
            while (oque != 0) {
                switch (oque)
                {
                    case 1:
                        oque = condicional();
                        break;
                    case 2:
                        string txt = Console.ReadLine();
                        string ret = maiuscula(txt);
                        Console.WriteLine(ret);
                        oque = 0;
                        break;
                    case 3:
                        dataehora();
                        oque = 0;
                        break;

                    case 0:
                        Console.WriteLine("bye!!!!!");
                        break;
                }
            }
        }
        public static int  condicional() {
            // se 10 maior que 5 então x = 3 se não x = 9
            int x = (10 > 5) ? 3 : 9;
            Console.WriteLine("x é"+ x.ToString());
            return 0;
        }

        public static string maiuscula(string str) {
            string strup = str.ToUpper();
            return strup;
        }
        public static void dataehora() {
            Console.WriteLine("DateTime.Now = " + DateTime.Now);
            Console.WriteLine("DateTime.Now.Ticks = " + DateTime.Now.Ticks);
            DateTime data = DateTime.Parse("2020-09-04");
            Console.WriteLine(data);
            DateTime dataconvert = DateTime.ParseExact("2020-04-09","yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(dataconvert);
            DateTime dataconvert2 = DateTime.ParseExact("09/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dataconvert2);
            TimeSpan td = new TimeSpan(900000000L);
            Console.WriteLine(td);
            //dia da semana
            DateTime d = DateTime.Parse("2019-06-26");
            Console.WriteLine(d.DayOfWeek);
            //data de agora
            DateTime dtn = DateTime.Now;
            Console.WriteLine(dtn);
            //add um mes a data atual
            dtn = dtn.AddMonths(1);
            Console.WriteLine(dtn);
            //diferença entre datas
            DateTime td1 = new DateTime(2020,04,09);
            DateTime td2 = new DateTime(2020, 04, 19);
            TimeSpan diferenca = td2.Subtract(td1);
            Console.WriteLine("a diferenã entre as datas é de "+diferenca.ToString().Substring(0,2)+" dias");

            DateTime d1 = new DateTime(1982, 6, 11,0,0,0, DateTimeKind.Local);
            DateTime d2 = new DateTime(1982, 6, 11, 0, 0, 0, DateTimeKind.Utc);
            Console.WriteLine(d1+"  -  "+d2.ToLocalTime());

        }


    }
}
