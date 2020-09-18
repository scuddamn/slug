using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force = 3;
    public float slowdown;
    Rigidbody rb;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        if(Input.GetKeyUp(right))
        {
            rb.velocity = rb.velocity * slowdown; 
        }

        //LEFT
        //if <left> is pressed
        if (Input.GetKey(left))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.left * force);
        }

        if (Input.GetKeyUp(left))
        {
            rb.velocity = rb.velocity * slowdown;
        }

        //DOWN
        //if <down> is pressed
        if (Input.GetKey(down))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.down * force);
        }

        if (Input.GetKeyUp(down))
        {
            rb.velocity = rb.velocity * slowdown;
        }

        //UP
        //if <up> is pressed
        if (Input.GetKey(up))
        {
            //apply a force using the "force" var
            rb.AddForce(Vector2.up * force);
        }

        if (Input.GetKeyUp(up))
        {
            rb.velocity = rb.velocity * slowdown;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<SpriteRenderer>().enabled = false;
    }
}
