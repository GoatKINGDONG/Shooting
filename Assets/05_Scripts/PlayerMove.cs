using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;    //   전역 변수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 5f;   //  지역 변수
        // 1. 사용자의 입력에 따라a
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        // 2. 방향이 필요하다
        // Vector3 dir = Vector3.right * h;
        Vector3 dir = new Vector3(h, v, 0);
        
        // 3. 이동하고 싶다
        //transform.Translate/*유니티에서 제공하는 함수*/(dir  * speed * Time.deltaTime);
        // p= p0 + velocity * time
        dir.Normalize();
        transform.position = transform.position + dir* speed * Time.deltaTime;
        
        
    }
}
