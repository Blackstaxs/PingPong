using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        console.active = false;
    }
    bool updateT;

    public GameObject console;

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            updateT = !updateT;
            if (updateT)
            {
                console.active = false;
            }
            else console.active = true;
        }
    }
}
