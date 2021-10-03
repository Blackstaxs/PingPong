using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1goal : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1Goal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if(!isPlayer1Goal)
            {
                GameObject.Find("Score").GetComponent<ScoreManager>().p1Scored();
                Debug.Log("p1 scored");
            }
            else
            {
                GameObject.Find("Score").GetComponent<ScoreManager>().p2Scored();
                Debug.Log("p2 scored");
            }
            
        }
    }

}
