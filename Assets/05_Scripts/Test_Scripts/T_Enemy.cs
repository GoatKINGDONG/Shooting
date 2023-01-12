using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Enemy : MonoBehaviour
{
    public float speed = 4.0f;
    // 타겟 따라가기
    public GameObject target;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // 타겟 방향으로 한번만 정하고 가기
        //// 1. 태어나서 1번 타겟 방향으로
        //dir = transform.position- target.transform.position;
        //dir.Normalize();

        // 30퍼센트 확률로 타겟으로 향하고 아니면 그냥 내려가기(1)
        // 1. 임의의 값이 있다.
        int percent = Random.Range(1, 101);
        // 2. 만약 값이 30퍼센트 이하면 타겟을 항햐고
        if(percent <= 30.0f)
        {
            dir = transform.position - target.transform.position;
            dir.Normalize();
        }
        // 3. 아니면 방향은 밑이다.
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 아래로 움직이기
        //// 1. 방향은 아래로
        //Vector3 dir = Vector3.down;
        //// 2. 움직인다.
        //transform.position += dir * speed * Time.deltaTime;

        // 타겟 따라가기
        //// 1. 방향은 타겟을 따라
        //dir = transform.position - target.transform.position;
        //dir.Normalize();
        //// 2. 움직인다.
        //transform.position += dir * speed * Time.deltaTime;

        // 타겟 방향으로 한번만 정하고 가기
        //// 2. 움직인다
        //transform.position += dir * speed * Time.deltaTime;

        // 30퍼센트 확률로 타겟으로 향하고 아니면 그냥 내려가기(2)
        // 4. 움직인다
        transform.position += dir * speed * Time.deltaTime;
    }
}
