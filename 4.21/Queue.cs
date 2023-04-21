using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4._21
{
    internal class Queue<T>
    {
        private int defultCapatacity = 4;               // 설정해야하는거 지정 array, head, tail
        private T[] array;                  
        private int head;
        private int tail;

        public Queue()
        {
            array = new T[defultCapatacity + 1];                // 초기설정 하면서 길이가 5인 배열설정
            head = 0;                                           // 배열의 가장 처음인 head 0는 
            tail = 0 ;                                          // 초기에는 haed랑 tail은 기본적으로 0에서 부터 시작 
        }
        public void EnQueue(T Value)                // 
        {
     
            if (IsFull())                           //꽉차면 Grow();
            { 
                Grow();
            }
            
            array[tail] = Value;                // 안차면 tail에 값을넣고
            MoveNext(ref tail);                 // tail을 한칸옆으로
            
        }
        private void MoveNext(ref int index)
        {

            index = array.Length - index > 0 ? index+1 : index + 0;            // 배열의 길이-index 가 0이면 길이가 5인 배열에 숫자가 전부있다는 소리니깐 0보다 큰값으로 하고 트루면
                                                                               // 옆으로 한칸이동 아니면 0칸이동
      
        }
        public void Grow()
        {
            int newarraylength = array.Length * 2;
            T[] newarray = new T[newarraylength];
            Array.Copy(array, newarray, 0);             //길이를 2배한 newarray에 기존에 있던 array를 0부터(첫번째부터)복사해서 붙여넣기
            array = newarray;                           // 그후 array를 newarray로 지정
        }

        private bool IsFull()
        {

            return head == tail;

        }

        private bool IsEmpty()
        {
            return head == tail;
        }


        public T DeQueue()
        {
            if (IsEmpty())                                          //아무것도 없으면 예외처리하고
                throw new InvalidOperationException();
                
            T First = array[head];                                  // 가장 처음에 넣은거 꺼내야하니 처음에 넣은head 값을 first 로 설정하고
            MoveNext(ref head);                                     // 
            return First;                                           // first 를 빼낸다.
        }

    }
    


}


// Count            IsFull()            IsEmpty()

/*queue 구현해야하는거
EnQueue 집어넣는거
DeQueue순 순서대로 출력
peek*/
