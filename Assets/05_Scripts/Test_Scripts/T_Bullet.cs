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
        // 위로 계속 올라간다.
        // 방향을 정한다.
        Vector3 dir = Vector3.up;
        // 이동한다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
