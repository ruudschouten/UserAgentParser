using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAgentParser;

namespace ParseTester {
    class Program {
        private static string LaptopUA = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
        private static string androidUA = @"Mozilla/5.0 (Linux; Android 7.0; ONEPLUS A3003 Build/NRD90M) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.154 Mobile Safari/537.36";
        private static string iphone4UA = @"Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3_2 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8H7 Safari/6533.18.5";
        private static string androidNexus4UA = @"Mozilla/5.0 (Linux; Android 4.3; Nexus 4 Build/JWR66Y) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.92 Mobile Safari/537.36";
        private static string androidNexus7UA = @"Mozilla/5.0 (Linux; Android 4.1.1; Nexus 7 Build/JRO03D) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Safari/535.19";
        private static string androidNexus6PUA = @"Mozilla/5.0 (Linux; Android 7.1.1; Nexus 6P Build/N4F26I) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.91 Mobile Safari/537.36";

        static void Main(string[] args) {
            var mobile = Parser.Parse(androidUA);
            var desktop = Parser.Parse(LaptopUA);
            var m1 = Parser.Parse(iphone4UA);
            var m2 = Parser.Parse(androidNexus4UA);
            var m3 = Parser.Parse(androidNexus7UA);
            var m4 = Parser.Parse(androidNexus6PUA);
            Console.WriteLine(mobile.ToString());
            Console.WriteLine(desktop.ToString());
            Console.WriteLine(m1.ToDetailedString());
            Console.WriteLine(m2.ToDetailedString());
            Console.WriteLine(m3.ToDetailedString());
            Console.WriteLine(m4.ToDetailedString());
            Console.ReadLine();
        }
    }
}
