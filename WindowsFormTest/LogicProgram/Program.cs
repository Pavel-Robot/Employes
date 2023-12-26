using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HelpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск программы");

            //Можно использовать явнотипизированный тип Person либо можно использовать упрощенное слова var
            var person = new Person("Самарин Илья Валерьевич", new DateTime(1994, 3, 20));
            // $ - символ интерполяции строк
            Console.WriteLine($"Создане person - {person.FullName}");

            Subdivision subdivision = new Subdivision("СибГУ");
            Subdivision subdivisionSFU = new Subdivision("СФУ");
            Console.WriteLine($"Создане subdivision - {subdivision.Name}");
            Sotrudnik sk = person.Accept(subdivision);
            Console.WriteLine($"Принят на работу сотрудник - {sk.FullName}");

            //Захотел поменять подразделение
            sk.Subdivision = subdivisionSFU;

            //Создаю новую колекцию типа List
            List<Sotrudnik> sotrudniks = new List<Sotrudnik>();

            //Добавляю своего сотрудника
            sotrudniks.Add(sk);

            ShowDataSotrudnik(sotrudniks);

            foreach (var _sk in sotrudniks)
            {
                //Хочу всех уволить
                _sk.Dissmised();
            }

            ShowDataSotrudnik(sotrudniks);

            //Удаля всех сотрудников у которых фио Самарин Илья Валерьевич
            sotrudniks.RemoveAll(x => x.FullName == "Самарин Илья Валерьевич");

            ShowDataSotrudnik(sotrudniks);

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод информации о сотрудниках
        /// </summary>
        /// <param name="sotrudniks">Сотрудники</param>
        public static void ShowDataSotrudnik(List<Employee> employee)
        {
            Console.WriteLine($"Всего сотрудников : {employee.Count}");
            Console.WriteLine($"Работающих сотрудников : {employee.Where(x => x.Status == Employee.InpStatus.Work).Count()}");
            Console.WriteLine($"Уволенных сотрудников : {employee.Where(x => x.Status == Employee.InpStatus.Dismissed).Count()}");
            
            foreach (var i in employee)
            {
                Console.WriteLine($"Сотрудник {i.FullName}");
            }
        }
    }
}