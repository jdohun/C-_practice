using System;
using static System.Console;

namespace ConsoleApp1 {
    class OneFor_FullDia {
        static void Main(string[] args) {
            while (true) {
                WriteLine("프로그램을 종료하시겠습니까? (Y/N)");
                String choice = ReadLine();

                if (choice.Equals("Y") || choice.Equals("y")) {
                    break;
                }
                else if (choice.Equals("N") || choice.Equals("n")) {

                    while (true) {
                        WriteLine("최대 별의 갯수를 홀수로 입력하세요 : ");
                        String input = ReadLine();
                        int num;

                        if (!int.TryParse(input, out num)) {
                            WriteLine("숫자 정수만 입력 가능합니다.");
                            continue;
                        }
                        if (num % 2 == 0 || num <= 0 || num > 30) {
                            WriteLine("30 이하의 양의 홀수 정수만 입력가능합니다.");
                            continue;
                        }

                        int half = num / 2;

                        for(int line = 0; line < num; ++line) {
                            if(line <= half) {
                                for (int blank = 0; blank < half - line; ++blank) {
                                    Write(" ");
                                }
                                for (int star = 0; star < 2 * line + 1; ++star) {
                                    Write("*");
                                }
                                WriteLine();
                            }
                            else {
                                for (int blank = 0; blank < line - half; ++blank) {
                                    Write(" ");
                                }
                                for (int star = 0; star < num - 2 * (line - half); ++star) {
                                    Write("*");
                                }
                                WriteLine();
                            }
                        }

                        break;
                    }
                }
                else {
                    WriteLine("잘못된 입력입니다.");
                }
            }
        }
    }
}