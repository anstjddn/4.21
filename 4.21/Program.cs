namespace _4._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _4._21.Stack<int> stack = new _4._21.Stack<int>();

            for (int i = 0; i < 5; i++) stack.Push(i);  // 입력순서 : 0 1 2 3 4

            Console.WriteLine(stack.Peek());            // 최상단 : 4

            while (stack.Peek != null)
            {
                Console.WriteLine(stack.Pop());         // 출력순서 : 4 3 2 1 0
            }

        }
    }
}

// 1. 스택(어댑터), 큐(순환배열) 구현+ 주석꼭달고
//------------------------------------------------------------1번은 필수 아래는 선택
//2 . 스택을 활용하면 쓸수있는게 괄호 검사기     ()(), (())  성공    |        ()), )()(    실패
//3. 스택을 활용한 계산기(아이디어 구글링 확인)
//4. 큐를 활용하여 속도가 빠른 플레이어부터 행동
//4. 요세푸스 순열