using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정 시간에 한번씩 적을 만들고 싶다
// 필요 속성 : 일정 시간, 경과 시간,적 공장, 
public class EnemyGod : MonoBehaviour
{
    // 필요속성 : 일정 시간 (생성 시간)
    public float createTIme = 2;
    // 경과시간
    float currentTime = 0;
    // 적공장
    public GameObject enemyFactory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTIme ) 
        {
            currentTime = 0;
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
        }

       

        // 일정 시간에 한번씩 적을 만들고 싶다.
        // 1. 시간이 흘렀으니까
        // 2. 일정 시간이 됐으니까 -> 만약 경과 시간이 생성 시간을 초과하면
        // 3. 적을 만들고 싶다.
    }
}
