using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // �����÷ο�
        //print("Hello World!!");
        //print(200 + 5);
        //int num1 = 200;
        //float num2 = 2.05f;

        //num1 = (int)num2; // ���� �÷ο찡 ���� �׷��� ��� ���� ��� ���� �����??(Ÿ�� ĳ����)
        //print(num1); // num1�� �����̰� num2�� �Ǽ���. �׷��� ĳ������ �ϸ� ������ �κи� �Է��� �Ǳ⿡ 2�� �ȴ�.

        // ���� number�� ���̶��
        // -> �ȳ��ϼ���. ��� // �����÷ο�

        // ���ǹ� 
        //bool num = true;
        //if (num)
        //{
        //    print("�ȳ��ϼ���");
        //}


        //float num1 = 2f;
        //float num2 = 1.0f;
        //if(num1> num2)
        //{
        //    print("num1�� �� Ů�ϴ�");
        //}
        //else
        //{
        //    print("num2�� �� Ů�ϴ�.");
        //}

        // �ݺ���
        //int num = 0;
        //for (int i = 0; i < 100; i++)
        //{
        //    // 100�� �ݺ��ϸ鼭 i�� ¦���� 1�� ������. i�� Ȧ���� 2�� ������
        //    if (i % 2 == 0 && i >= 20)
        //    {
        //        num += 1;
        //    }

        //}
        //print(num);

        //x �׸��� y �׸��� z

        //  ���ϱ� ����� ����� ����
        //  ��ȯ�ڷ��� �Լ��̸�([�μ�,...])

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
