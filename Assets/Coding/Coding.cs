using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // 오버플로우
        //print("Hello World!!");
        //print(200 + 5);
        //int num1 = 200;
        //float num2 = 2.05f;

        //num1 = (int)num2; // 오버 플로우가 난거 그래도 어느 정도 담긴 것은 써야지??(타입 캐스팅)
        //print(num1); // num1은 정수이고 num2는 실수다. 그러니 캐스팅을 하면 정수인 부분만 입력이 되기에 2로 된다.

        // 만약 number가 참이라면
        // -> 안녕하세요. 출력 // 오버플로우

        // 조건문 
        //bool num = true;
        //if (num)
        //{
        //    print("안녕하세요");
        //}


        //float num1 = 2f;
        //float num2 = 1.0f;
        //if(num1> num2)
        //{
        //    print("num1이 더 큽니다");
        //}
        //else
        //{
        //    print("num2이 더 큽니다.");
        //}

        // 반복문
        //int num = 0;
        //for (int i = 0; i < 100; i++)
        //{
        //    // 100번 반복하면서 i가 짝수면 1을 더하자. i가 홀수면 2를 더하자
        //    if (i % 2 == 0 && i >= 20)
        //    {
        //        num += 1;
        //    }

        //}
        //print(num);

        //x 그리고 y 그리고 z

        //  더하기 기능을 만들어 보자
        //  반환자료형 함수이름([인수,...])

        int result = Plus(200, 5);
        print(result);
    }
    int Plus(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
