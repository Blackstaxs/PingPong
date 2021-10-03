using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    public Transform ball;
    private Vector2 movement;
    private Rigidbody rb;
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = ball.position - transform.position;
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveP2(movement);
    }

    void moveP2(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
