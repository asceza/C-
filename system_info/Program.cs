//Программа демонстрирует использование класса Environment из
//пространства имен System.
//Класс Environment предназначен для работы с переменными окружения
//операционной системы Windows.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TEST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "System info";

            // Класс Environment предоставляет сведения о текущей среде окружения и
            // платформе, а также необходимые для управления ими средства.
            // В данном случае подразумевается среда окружения, предоставляемая
            // операционной системой Windows для всех программ, работающих в ней.

            Console.Write("ОС: " + Environment.OSVersion);
            if (Environment.Is64BitOperatingSystem) 
            { 
                Console.WriteLine(" (64bit)"); 
            }
            else
            {
                Console.WriteLine(" (32bit)");
            }

            Console.WriteLine("Имя ПК: " + Environment.MachineName); //возвращает имя данного компьютера
            Console.WriteLine("Имя Пользователя: " + Environment.UserName);

            //Свойство OSVersion возвращает объект OperatingSystem, который содержит  
            //идентификатор текущей платформы и номер версии. Метод ToString() возвращает
            //текстовое представление объекта.
            Console.WriteLine("\nOSVersion (Версия ОС): {0}", Environment.OSVersion.ToString());

            //Свойство WorkingSet возвращает число байтов  физической памяти, сопоставленной процессу. 
            //выполнил вход в операционную систему Windows.
            Console.WriteLine("\nWorkingSet (Объем памяти в байтах): {0}", Environment.WorkingSet);

            //Свойство CurrentDirectory возвращает или задает полный путь к текущей рабочей папке.
            Console.WriteLine("\nCurrentDirectory (Текущий каталог): {0}", Environment.CurrentDirectory);

            //Свойство CommandLine возвращает командную строку для данного процесса.
            Console.WriteLine("\nCommandLine (Командная строка): {0}", Environment.CommandLine);

            //Свойство SystemDirectory возвращает полный путь к системному каталогу. 
            Console.WriteLine("\nSystemDirectory (Системный каталог): {0}", Environment.SystemDirectory);

            //Метод GetLogicalDrives() возвращает массив строк, содержащий имена
            //логических дисков текущего компьютера. 
            String[] drives = Environment.GetLogicalDrives();
            Console.WriteLine("\nGetLogicalDrives (Получить имена логических дисков): {0}", String.Join(", ", drives));

            //Метод GetFolderPath() возвращает путь к особой системной папке,
            //указанной в заданном перечислении Environment.SpecialFolder. 
            Console.WriteLine("\nGetFolderPath (Получить путь к системной папке): {0}",
                         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            //Метод GetEnvironmentVariables() возвращает Объект IDictionary, в котором содержатся 
            //имена всех переменных среды и их значения в виде пары "ключ-значение".
            //Для работы с объектом IDictionary необходимо в начало модуля вставить строку
            //"using System.Collections;".
            Console.WriteLine("\nGetEnvironmentVariables (Получить переменные среды): ");
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
        }
    }
}
