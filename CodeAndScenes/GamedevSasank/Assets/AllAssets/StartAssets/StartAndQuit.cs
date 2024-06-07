using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndQuit : MonoBehaviour
{
    public int opt =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s"))
        {
            restart();
        }
        if(Input.GetKeyDown("e"))
        {
            Application.Quit();
        }
    }

    void restart()
    {
        SceneManager.LoadScene("finalgame");
    }
}
