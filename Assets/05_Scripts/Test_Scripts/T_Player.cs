using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Player : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���ϴ� �������� �����δ�.
        // 1. Ű���带 �д´�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        // 2. ������ ���Ѵ�.
        Vector3 dir = new Vector3(h, v,0);
        // 3. �����δ�
        transform.position += dir * speed * Time.deltaTime;
    }
}
