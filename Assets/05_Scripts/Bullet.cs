using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    // 계속 위로 이동하고 싶다
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 
        // 2. 방향은 위로
        // 3. 이동하고 싶다
        
        
        //Vector3 dir = new Vector3(0,1, 0);
        //transform.position = transform.position + dir * speed * Time.deltaTime;

        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
