using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
    // 배경을 스크롤 하고 싶다.
    // 필요 속성 : 머티리얼, 스크롤 속도, 
    Material bgMat;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        // 1. Mesh Renderer의 본 소유주? 게임 오브젝트가 필요하다.
        // 1.2. Mesh Renderer 컴포넌트가 필요하다.
        MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>(); // 다 .찍어서 transform처럼 컴포넌트를 불러올 수 있는 것 은 아니다.
        // 1.3. 배경(머티리얼)이 필요하다.
        bgMat = mr.material;
        // 렌더러가 갖고 있는 맵 컴퍼넌트
        // 렌더러가 갖고 있는 머티리얼

        
    }

    
    void Update()
    {
        // 배경을 스크롤 하고 싶다.
        // 2. 스크롤 하고 싶다.
        bgMat.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
