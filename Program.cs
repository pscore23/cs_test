using System;

namespace Program {
    public class HelloWorld {
        public static void Main(string[] args) {
            string test = "Hello, World!";

            Action<string> write = (text) => Console.WriteLine(text);

            write(test);
        }
    }
}