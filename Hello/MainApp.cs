using System;
// using static은 클래스의 정적 멤버를 데이터 형식의 이름을 명시하지 않고
// 참조하겠다고 선언하는 기능
using static System.Console;

// namespace는 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자, 열거형식
// 등을 하나의 이름 아래 묶는 일을 한다.
namespace Hello
{
    class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        // static 한정자(modifier)는 프로그램이 처음 구동될 때부터 진작에 메모리에 할당된다.
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법: Hello.exe <이름>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
