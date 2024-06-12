namespace Name {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0 || args[0] == "-h" || args[0] == "--help") {
                Console.WriteLine("Enter a binary string of up to 8 digits (only 0 and 1 allowed)");
                return;
            }
            var binString = args[0];
            foreach (char c in binString) {
                if (c != '0' && c != '1') {
                    Console.WriteLine("Invalid binary string! Only 0 and 1 allowed.");
                    return;
                }
            }
            if (binString.Length > 8) {
                Console.WriteLine("Binary string too long! Only 8 characters allowed.");
                return;
            }
            int exponent = binString.Length - 1;
            int dec = 0;
            foreach (char c in binString) {
                int n = int.Parse(c.ToString());
                dec += n * (int)Math.Pow(2, exponent);
                exponent--;
            }
            Console.WriteLine($"{binString} is {dec} in decimal.");
        }
    }

}