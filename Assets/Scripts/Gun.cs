using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // 총알의 갯수 - 데이터 [변수]
    // 1개,2개,3개
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text txtBulletCount;

    private void Start()
    {
        RefreshBulletCountUI();
    }


    // 총알을 발사 - 기능 [함수]
    // 총을 쏜다
    public void Shoot()
    {
        if (bulletCount <= 0)
            return;


        // 오브젝트를 생성
        // Instantiate(bullet);

        // 오브젝트를 생성 - firePos 안쪽에 위치
        // Instantiate(bullet, firePos);

        // 오브젝트를 생성 - Vector의 위치,   Quaternion 의 회전값
        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);
        bulletObj.AddForce(firePos.forward * 100 , ForceMode.Impulse);

        bulletCount--;

        RefreshBulletCountUI();
    }

    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }
}
