using System;

// Побитовые логические операции. (&, |)

// Например: 
// Мы имеем порт ввода/вывода или регистр с определенным значением в нем.
// Нам необходимо включить устройство управляемое первым битом, установив первый бит в 1.
// После нам потребуется выключить устройство, сбросив первый бит в 0.
//  1 1 1 1   0 0 0 0  -  начальное значение порта ввода/вывода.
//  7 6 5 4   3 2 1 0  -  нумерация битов управления устройствами.

namespace Logic
{
    class Program
    {
        //Convert.ToString(byte value, int toBase) позволяет увидеть число в двоичном формате

        // Сводка:
        //     Преобразует значение заданного 8-битового целого числа без знака в эквивалентное
        //     строковое представление в указанной системе счисления.
        //
        // Параметры:
        //   value:
        //     8-разрядное целое число без знака для преобразования.
        //
        //   toBase:
        //     Основание системы счисления возвращаемого значения, равное 2, 8, 10 или 16.
        //
        // Возврат:
        //     Строковое представление значения параметра value в системе счисления с основанием
        //     toBase.
        //
        // Исключения:
        //   T:System.ArgumentException:
        //     toBase не равно 2, 8, 10 или 16.
        static void Main()
        {
            
            Console.Write(new string('.', Console.WindowWidth));
            byte port = 0xF0;     // 1 1 1 1   0 0 0 0  -  начальное значение порта ввода/вывода.
            byte mask = 0x02;     // 0 0 0 0   0 0 1 0  -  маска включения устройства управляемого первым битом.
            Console.WriteLine("port = {0:X}", port); // ситуация с лампочкой в комнате
            Console.WriteLine(Convert.ToString(port, 2));
            Console.Write(new string('.', Console.WindowWidth));

            port = (byte)(port | mask);  // Включить устройство управляемое первым битом.
            Console.WriteLine("port = {0:X}", port);
            Console.WriteLine(Convert.ToString(port, 2));
            mask = 0xFD;          // 1 1 1 1   1 1 0 1  -  Создаем маску выключения устройства управляемого первым битом. 
            Console.WriteLine("mask = {0:X}", mask);
            Console.WriteLine(Convert.ToString(mask, 2));
            Console.Write(new string('.', Console.WindowWidth));

            Console.WriteLine("Конъюнкция");
            Console.WriteLine(Convert.ToString(port, 2));
            port = (byte)(port & mask);  // Выключить устройство управляемое первым битом.
            Console.WriteLine(Convert.ToString(mask, 2));
            Console.Write(new string('_', Console.WindowWidth));
            Console.WriteLine(Convert.ToString(port,2));
            Console.WriteLine("port = {0:X}", port); //1 1 1 1 0 0 0 0 Результат
            Console.Write(new string('.', Console.WindowWidth));

            // Delay.
            Console.ReadKey();
        }
    }
}
