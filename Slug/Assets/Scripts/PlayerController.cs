using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force = 5;
    Rigidbody2D rb;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //RIGHT
        //if <right> is pressed
        if (Input.GetKey(right))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.right * force);
        }

        //LEFT
        //if <left> is pressed
        if (Input.GetKey(left))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.left * force);
        }

        //DOWN
        //if <down> is pressed
        if (Input.GetKey(down))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.down * force);
        }

        //UP
        //if <up> is pressed
        if (Input.GetKey(up))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.up * force);
        }
    }
}
