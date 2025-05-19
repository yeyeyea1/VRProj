using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int targetScore;

    private void Start()
    {
        RePosition();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Score += targetScore;
        Destroy(gameObject);
    }

    public void RePosition()
    {
        float randomX = Random.Range(-4, 4);
        float randomY = Random.Range(1, 3);

        Vector3 rePos = transform.position;
        rePos.x= randomX;
        rePos.y= randomY;

        transform.position = rePos; 
    }
}
