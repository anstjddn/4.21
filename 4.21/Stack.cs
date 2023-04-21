using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._21
{
    internal class Stack<T>
    {
        private List<T> list;               // Stack이라는 클래스는 초기에 List를 설정해야한다. 그리고 외부에서 접근하지 못하게 private로 설정

        public Stack()
        {
            list = new List<T>();           //Stack 안에 새로운 List를 생성
        }
        public void Push(T value)          //Stack.Push 함수를 구현. value 를 T를 한 이유는 List안에 여러 자료형이 들어갈수 있기때문에
        {
            list.Add(value);                // Stack안에 List를 설정해서 List에서 구현된 함수를 이용 

        }
        public T Pop()                           // 가장 마지막에 넣은걸 출력하고 버리기
        {   
            
            T item = list.Last();
            list.Remove(item);
            if (item == null)
                throw new InvalidOperationException();
            return item;
                                           // 이거 제대로 출력되는데 마지막에 예외처리 해야댐
        }

        public T Peek()                 // 스택에서 가장 마지막에 넣은거를 어차피 listadd로 뒤쪽으로 붙으므로 list.Last로 구현
        {
            return list.Last();         
        }





        //구현해야하는거 Push   계속넣으면  
        //Pop
        /*          Push 넣는거 블록쌓기						
                pop 처음부터 출력하는거
                peek 가장 위에있는거 출력


                queue
                구현해야하는거 
                EnQueue				집어넣는거
                DeQueue순		순서대로 출력
                peek       */

    }
}
