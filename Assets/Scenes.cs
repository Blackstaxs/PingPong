using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene1()
    {
        SceneManager.LoadScene("pvp");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("pve");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Main");
    }
}
