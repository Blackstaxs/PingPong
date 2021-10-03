using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject p1Paddle;
    public GameObject p1Goal;
    public GameObject p2Paddle;
    public GameObject p2Goal;
    public GameObject p1text;
    public GameObject p2text;
    private int p1score;
    private int p2score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void p1Scored()
    {
        p1score++;
        p1text.GetComponent<TMPro.TextMeshProUGUI>().text = p1score.ToString();
        ResetPosition();
        if (p1score == 2)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
    public void p2Scored()
    {
        p2score++;
        p2text.GetComponent<TMPro.TextMeshProUGUI>().text = p2score.ToString();
        ResetPosition();
        if(p2score == 2)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }

    private void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
    }
}
