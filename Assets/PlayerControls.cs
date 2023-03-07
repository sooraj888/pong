using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;
    int paddleMovement;
    // Start is called before the first frame update
    void Start()
    {
        paddleMovement = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    public void onButtonUp()
    {
        paddleMovement = 1;
      
    }
    public void onButtonDown()
    {
        paddleMovement = -1;

    }
    public void onRelease()
    {
        paddleMovement = 0;
     
    }

    void Update()
    {
        Debug.Log(paddleMovement);
        var vel = rb2d.velocity;
        if (paddleMovement==1)
        {
            vel.y = speed;
        }
        else if (paddleMovement == -1)
        {
            vel.y = -speed;
        }
        else if (paddleMovement == 0)
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}
