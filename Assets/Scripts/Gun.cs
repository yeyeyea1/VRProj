using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text txtBulletCount;

    private void Start()
    {
        RefreshBulletCountUI();
    }

    public void shoot()
    {
        if (bulletCount <= 0)
            return;

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
