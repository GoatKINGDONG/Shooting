using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 사용자가 발사 버튼을 누르면 총알을 발사하고 싶다.
    // 필요 속성 : 총알 공장, 총구의 위치
    public GameObject bulletFactory;
    public GameObject firePostion;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 발사 버튼을 누르면 총알을 발사하고 싶다.
        // 1. 사용자가 발사 버튼을 눌렀으니까
        // -> 만약 사용자가 발사 버튼을 눌렀다면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 총알이 있어야한다.
            GameObject bullet = Instantiate(bulletFactory); // 데이터 형식 bullet = 갖고와줘(무엇을);
            // 3. 총알을 발사하고 싶다.(위치시킨다.)
            bullet.transform.position = firePostion.transform.position;
        }

    }
}
