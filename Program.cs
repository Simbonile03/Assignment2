namespace Assignment2
{

     class Program 
    {
        static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        static void Main()
        {
            Console.Write("Enter number up to (9999: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 9999 )
            {
                Console.WriteLine("Please enter a number between 0 and 9999.");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                string words = ConvertToWords(number);
                Console.WriteLine($"{number} -> {words}");
            }
        }

        static string ConvertToWords(int number)
        {
            if (number == 0)
            {
                return "";
            }

            if (number < 10)
            {
                return units[number];
            }
            else if (number < 20)
            {
                return teens[number - 11];
            }
            else if (number < 100)
            {
                return $"{tens[number / 10]} {ConvertToWords(number % 10)}";
            }
            else if (number < 1000)
            {
                return $"{units[number / 100]} Hundred {ConvertToWords(number % 100)}";
            }
            else
            {
                return $"{units[number / 1000]} Thousand {ConvertToWords(number % 1000)}";
            }

            

        }
    }
}


