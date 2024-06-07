using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _target = GameObject.FindGameObjectWithTag("targ");
        float targetYPosition = _target.transform.position.y;
        if(targetYPosition <= 3.50)
        {
            SceneManager.LoadScene("StartScreen");
        }
        if(Input.GetKeyDown("m"))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
