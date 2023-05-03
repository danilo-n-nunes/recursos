using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefEOut {
    class Calculator {

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void Triple(int x, out int y) {
            y = x * 3;
        }
    }
}
