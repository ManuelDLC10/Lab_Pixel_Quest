using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool sawPlayer = false;
    public GameObject Player;


    private void Update()
    {
        if (sawPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 2*Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Sword")
        {
            Destroy(gameObject);
        }
    }
}
