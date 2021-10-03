using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ConsoleChat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool showConsole;
    string input;
 

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        
    }

    [System.Obsolete]
    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 80, 20), "     ");
        input = GUI.TextField(new Rect(0, 0, 80, 20), input);
  
    }
}
