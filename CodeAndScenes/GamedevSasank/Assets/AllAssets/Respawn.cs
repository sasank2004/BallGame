using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public bool isclick;
    //public float counter1 = 301, counter2 =0;
    public float counter1 = 0f, counter2 = 0f;
    public Vector3 direction;
    public Transform teleporttarg;
    Rigidbody rb;
    GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        GameObject _ball = GameObject.FindGameObjectWithTag("Player");
        Ball = _ball;
        rb = Ball.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(counter2 == 0f)
        {
            keyvalue();
            //isclick = true;
        }
        if(counter1 < 100f & counter1>0f)
        {
            Debug.Log("Why Increase");
            counter1 += 1f;
        }
        if(counter1 == 100f)
        {
            Debug.Log("You RESET");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<DirectionTrack>().enabled = true;
            direction.x = 0f;
            direction.y = -0.702f;
            direction.z = -0.85f;
            //rb.useGravity = false;
            Ball.transform.localPosition = new Vector3(0f,-0.702f,-0.85f);
            counter1 += 2f;
        }
        /*if(counter1 == 302);
        {
            Application.Quit();
        }*/
    }

    void keyvalue()
    {
        if(isclick == true)
        {
            counter1 = 1f;
            counter2 = 1f;
            Debug.Log("KeyDown");
            Debug.Log(Input.GetKeyUp(KeyCode.Space));
        }

    }

    void Update()
    {
        isclick = Input.GetKey("r");
        if(Input.GetKey("r"))
        {
            counter2 = 0;
        }
    }

    /*void update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            isclick = false;
        }

    }*/
    // Update is called once per frame
}
