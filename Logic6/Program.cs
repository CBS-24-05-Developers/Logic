using System;

// Логический Сдвиг  (shift).

namespace Logic
{
    class Program
    {
        static void Main()
        {           
            byte operand = 0x81;              // 1000 0001    
            Console.WriteLine("Число до сдвига: {0:X}", operand);
            Console.WriteLine($"{Convert.ToString(operand, 16)} === в двочном { Convert.ToString(operand, 2)}");
            // Логический сдвиг числа влево.

            operand = (byte)(operand << 2);   // 0000 0100
            Console.WriteLine("Число после сдвига влево: {0:X}", operand);
            Console.WriteLine($"{Convert.ToString(operand, 16)} === в двочном { Convert.ToString(operand, 2)}");

            // Логический сдвиг числа вправо.

            operand = (byte)(operand >> 1);   // 0000 0010

            Console.WriteLine("Число после сдвига вправо: {0:X}", operand);
            Console.WriteLine($"{Convert.ToString(operand, 16)} === в двочном { Convert.ToString(operand, 2)}");

            // Delay.
            Console.ReadKey();
        }
    }
}
