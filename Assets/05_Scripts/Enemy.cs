using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject target;
    
    Vector3 dir; // 전역변수로 Start와 Update에 불러지도록 선언
    // Start is called before the first frame update
    void Start()
    {
        int percent = Random.Range(1, 101);
        // 한번에 방향잡기
        // 태어날 때 딱 한번 타겟 방향으로 찾고
        //dir = target.transform.position - transform.position;
        //dir.Normalize(); // 대각선 속도 맞추기 속력 x 힘의 크기 x 방향 -> 힘의 크기를 1로 맞추는 것 그래야 속도를 맞추며 감

        //  30퍼 확률    
        if (percent <= 31)
        {
            dir = target.transform.position - transform.position;       
            dir.Normalize();
        }
        else { dir = Vector3.down; }
        
        Debug.Log(percent);
    }

    // Update is called once per frame
    void Update() 
    {
        // 적이 아래로 들어가기 ---------------------------------------------
        //  적이 이동한다.
        //  방향은 아래로
        //Vector3 dirdwn = Vector3.down;
        //transform.position += dirdwn * speed *Time.deltaTime;

        // 적이 나를 따라다니기 ---------------------------------------------
        //Vector3 follow = transform.position- target.transform.position;
        //follow.Normalize();
        //transform.position += follow * speed * Time.deltaTime;


        // 한번에 방향잡기
        // 이동한다
        // 방향은 타겟으로
        // 15번 ~ 16번
        transform.position = transform.position + dir * speed * Time.deltaTime;

    }
}
