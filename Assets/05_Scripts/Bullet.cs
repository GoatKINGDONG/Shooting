using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    // ��� ���� �̵��ϰ� �ʹ�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 
        // 2. ������ ����
        // 3. �̵��ϰ� �ʹ�
        
        
        //Vector3 dir = new Vector3(0,1, 0);
        //transform.position = transform.position + dir * speed * Time.deltaTime;

        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
