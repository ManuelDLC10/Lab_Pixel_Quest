using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    public EnemyScript EnemyScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            EnemyScript.Player = collision.gameObject;
            EnemyScript.sawPlayer = true;
        }
    }
}
