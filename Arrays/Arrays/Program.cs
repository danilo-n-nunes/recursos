using System.Globalization;

namespace Arrays {

    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // int m = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for(int i = 0;i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product { Name = name, Price = price };

            }

            double sum = 0.0;

            for(int i = 0; i < n ; i++) {
                sum += products[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
