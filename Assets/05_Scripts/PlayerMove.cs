using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;    //   ���� ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 5f;   //  ���� ����
        // 1. ������� �Է¿� ����a
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        // 2. ������ �ʿ��ϴ�
        // Vector3 dir = Vector3.right * h;
        Vector3 dir = new Vector3(h, v, 0);
        
        // 3. �̵��ϰ� �ʹ�
        //transform.Translate/*����Ƽ���� �����ϴ� �Լ�*/(dir  * speed * Time.deltaTime);
        // p= p0 + velocity * time
        dir.Normalize();
        transform.position = transform.position + dir* speed * Time.deltaTime;
        
        
    }
}
