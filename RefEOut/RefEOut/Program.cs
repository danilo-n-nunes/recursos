using RefEOut;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            int tripple;

            Calculator.Triple(ref a);
            Calculator.Triple(a, out tripple);
            Console.WriteLine(a);
            Console.WriteLine(tripple);
        }
    }
}
