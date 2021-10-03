using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pinPong : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1;
    public float speed;
    public Rigidbody rb;
    private float movement;
    public Vector3 startPosition;

  
    void Start()
    {
        startPosition = transform.position;
    }

                                                    // Update is called once per frame
        void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("p1");
        }
        else
        {
            movement = Input.GetAxisRaw("p2");
        }

        rb.velocity = new Vector3(rb.velocity.x, movement * speed, 0);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
