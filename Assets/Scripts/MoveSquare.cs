using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public float speed;
    public KeyCode keyUp;
    public KeyCode keyDown;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyUp) && transform.position.y<4.5)
        {
            rigidbody2D.velocity = Vector2.up*speed;
        }
        else if (Input.GetKey(keyDown) && transform.position.y > -4.5)
        {
            rigidbody2D.velocity = Vector2.down*speed;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }

        
    }
}
