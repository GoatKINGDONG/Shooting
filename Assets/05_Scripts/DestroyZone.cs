using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // 나랑 부딪히는 녀석은 다 죽여버리겠다!!
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);    
    }
}
