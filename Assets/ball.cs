using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody rb;
    public Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint cp = collision.contacts[0];
        if (collision.gameObject.tag == "player")
        {
            Debug.Log("PLAYER");
            
            rb.velocity = Vector3.Reflect(rb.position, cp.normal);
        }

        if (collision.gameObject.tag == "p2goal")
        {
            GameObject.Find("Score").GetComponent<ScoreManager>().p1Scored();
            Debug.Log("p1 scored");
        }
        if (collision.gameObject.tag == "p1goal")
        {
            GameObject.Find("Score").GetComponent<ScoreManager>().p2Scored();
            Debug.Log("p2 scored");
        }
        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("WALL");

            rb.velocity = new Vector3(transform.position.x, -transform.position.y, 0);


        }
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector3(speed * x, speed * y, 0);
    }
}
