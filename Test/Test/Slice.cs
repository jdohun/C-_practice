using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Slice {
    class MainApp {
        static void PrintArray( System.Array array ) {
            foreach (var e in array) {
                Write(e );
            }
            WriteLine();
        }
        
        static void Main(string[] args ) {
            char[] array = new char['Z'-'A'+1]; // ASCII 코드 90 - 65 + 1 = 26
            for (int i = 0; i < array.Length; ++i) {
                array[i] = (char)('A' + i); // A ~ Z 까지 입력
            }

            PrintArray(array[..]); // 전체 출력
            PrintArray(array[5..]); // 5번쨰부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); // 5번쨰부터 9(10-1)까지

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]); // 5번쨰부터 끝(^)까지

            PrintArray(array[^4..^1]); // 끝에서 4번째부터 끝(^)에서 2번째까지
        }
    }
}
