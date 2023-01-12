using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject target;
    
    Vector3 dir; // ���������� Start�� Update�� �ҷ������� ����
    // Start is called before the first frame update
    void Start()
    {
        int percent = Random.Range(1, 101);
        // �ѹ��� �������
        // �¾ �� �� �ѹ� Ÿ�� �������� ã��
        //dir = target.transform.position - transform.position;
        //dir.Normalize(); // �밢�� �ӵ� ���߱� �ӷ� x ���� ũ�� x ���� -> ���� ũ�⸦ 1�� ���ߴ� �� �׷��� �ӵ��� ���߸� ��

        //  30�� Ȯ��    
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
        // ���� �Ʒ��� ���� ---------------------------------------------
        //  ���� �̵��Ѵ�.
        //  ������ �Ʒ���
        //Vector3 dirdwn = Vector3.down;
        //transform.position += dirdwn * speed *Time.deltaTime;

        // ���� ���� ����ٴϱ� ---------------------------------------------
        //Vector3 follow = transform.position- target.transform.position;
        //follow.Normalize();
        //transform.position += follow * speed * Time.deltaTime;


        // �ѹ��� �������
        // �̵��Ѵ�
        // ������ Ÿ������
        // 15�� ~ 16��
        transform.position = transform.position + dir * speed * Time.deltaTime;

    }
}
