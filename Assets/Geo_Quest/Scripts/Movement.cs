using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{



    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_2";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);

        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }



    private void OnTriggerEnter2D(Collider2D collision) 
    
    
    {
        switch (collision.tag)
        {
            case "Death":
                {
                   string thisLevel = SceneManager.GetActiveScene().name; 
                    SceneManager.LoadScene(thisLevel);
                    break;
                    Debug.Log("Player Has Died");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }


        }
        
        Debug.Log(collision.tag);
    }

  




    /*

     if (Input.GetKeyDown(KeyCode.S))
     {
         transform.position += new Vector3(0, -1, 0);
     }


     if (Input.GetKeyDown(KeyCode.W))
     {
         transform.position += new Vector3(0, 1, 0);
     }

     if (Input.GetKeyDown(KeyCode.A))
     {
         transform.position += new Vector3(-1, 0, 0);
     }

     if (Input.GetKeyDown(KeyCode.D))
     {
         transform.position += new Vector3(-1, 0, 0);
     }


    if (Input.GetKeyDown(KeyCode.S))
    {
        transform.position += new Vector3(0, -1, 0);
    }

    if (Input.GetKeyDown(KeyCode.D))

    {
        transform.position += new Vector3(1, 0, 0);
    }

    if (Input.GetKeyDown(KeyCode.A))
    {
        transform.position += new Vector3(-1, 0, 0);
    }

    if (Input.GetKeyDown(KeyCode.W))

    {
        transform.position += new Vector3(0, 1, 0);
    }

    {
        rb.velocity = new Vector2(-1, rb.velocity.y);
    }
    */
}
   


