using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Bullet : MonoBehaviour
{
    public float speed = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ��� �ö󰣴�.
        // ������ ���Ѵ�.
        Vector3 dir = Vector3.up;
        // �̵��Ѵ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
