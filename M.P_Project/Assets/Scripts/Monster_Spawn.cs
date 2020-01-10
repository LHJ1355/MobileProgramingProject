using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Spawn : MonoBehaviour
{
    public GameObject Monster_pre; // 적 프리팹
    float sponTime = 5.0f;  // 리스폰 시간 ( 3초에 1번 소환)
    void Update()
    {
        sponTime -= Time.deltaTime;  // 리스폰 시간을 깍음.
        if (sponTime < 0)                  // 리스폰 시간이 0이 되었는지 검사
        {
            Instantiate(Monster_pre, transform.position, Quaternion.identity); // 생성
            sponTime = 5.0f;                                                    // 리스폰시간 초기화
        }
    }
}
