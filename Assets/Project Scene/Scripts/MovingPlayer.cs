using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  MovingPlayer : MonoBehaviour
{
    private Rigidbody2D _rigRigidbody2D;
    private float _xVelocity = 0f;
    private float _yVelocity = 0f;
    public float speed = 3;
    public string nextLevel = "Scene_2";
    enum facing {North, South, East, West};
    facing CurrentlyFacing = facing.South;

    Vector2 InputDirection;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        _xVelocity = Input.GetAxis(HW3Structs.Input.horizontal);
        _yVelocity = Input.GetAxis(HW3Structs.Input.vertical);
        InputDirection = new Vector2(_xVelocity, _yVelocity);


        _rigRigidbody2D.velocity = InputDirection.normalized * speed;

        if (InputDirection == Vector2.down)
        {
            CurrentlyFacing = facing.South;
        }
        else if (InputDirection == Vector2.up)
        {
            CurrentlyFacing = facing.North;
        }
        else if (InputDirection == Vector2.right)
        {
            CurrentlyFacing = facing.East;
        }
        else if (InputDirection == Vector2.left)
        {
            CurrentlyFacing = facing.West;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }


    }
}
