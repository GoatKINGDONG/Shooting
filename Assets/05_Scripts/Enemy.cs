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
        // 태어날 때 동적으로 씬(월드)에 있는 게임오브젝트(타겟) 찾기(프리팹에 있는 애들한테 넣어주기)
        target = GameObject.Find("Player");
        int percent = Random.Range(1, 101);
        // 한번에 방향잡기
        // 태어날 때 딱 한번 타겟 방향으로 찾고
        //dir = target.transform.position - transform.position;
        //dir.Normalize(); // 대각선 속도 맞추기 속력 x 힘의 크기 x 방향 -> 힘의 크기를 1로 맞추는 것 그래야 속도를 맞추며 감

        //  30퍼 확률    -> 그리고 타겟이 있다면(오류 수정 중)
        if (percent <= 31 && target != null/*!=null 생략가능 null이 아니면 true, null이면 false로 처리한다*/)
        {
            dir = target.transform.position - transform.position;       
            dir.Normalize();
        }
        else { dir = Vector3.down; }
        
        
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

    // 다른 물체와 부딪히면 부딪힌 녀석 없애고, 나도 죽고 싶다.
    // 다른 물체와 부딪히면 호출되는 함수 -> Callback function이라고 함
    public GameObject explosionFactory;
    // 부딪히면 폭발효과를 발생시키고 싶다.
    private void OnCollisionEnter(Collision other)
    {
        
        //폭발 공장에서 폭발효과를 발생시키고 싶다.
        // 필요 속성 : 폭발 공장
        // 위치
        //폭발 공장에서 폭발 만들고
        GameObject explosion = Instantiate(explosionFactory);
        //배치하고 싶다.
        explosion.transform.position = this.transform.position;
        

        //부딪힌 녀석 없애고, 나도 죽고 싶다.
        Destroy(other.gameObject); //없앤다(부딪힌 애.게임오브젝트 자체를) !! 순서는 굉장히 중요하다.
        Destroy(this.gameObject);
    }
}
