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
        // 내가 원하는 방향으로 움직인다.
        // 1. 키보드를 읽는다
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        // 2. 방향을 정한다.
        Vector3 dir = new Vector3(h, v,0);
        // 3. 움직인다
        transform.position += dir * speed * Time.deltaTime;
    }
}
