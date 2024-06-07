using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    Vector3 ImpulseVector = new Vector3(0f,0f,10f);
    public float starttime=0, endtime=0, deltime=0, counter=0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    void Update()
    {
        ImpulseVector.x += Input.GetAxis("Mouse X") ;
        ImpulseVector.y += 0.0005f + Input.GetAxis("Mouse Y") ;
        if(Input.GetKey("r"))
        {
            counter = 0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if(counter == 1)
        {
            updater();
            counter += 1;
        }
        if(starttime == 0f)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                starttime = Time.time;
            }
        }
            

        if(endtime == 0f)
        {
            if(!Input.GetKey(KeyCode.Space))
            {
                if(starttime != 0f)
                {
                    endtime = Time.time;
                    deltime = endtime - starttime;
                    if(deltime > 0.55f)
                    {
                        deltime = 0.55f;
                    }
                    if(counter == 0f || counter == 1f || counter == 2f)
                    {
                        if(counter == 1f)
                        {
                            Debug.Log("Counter IS 1");
                        }
                        impulsefxn();
                    }
                }
            }
        }
    }

    void updater()
    {
        starttime = 0f;
        endtime = 0f;
    }

    void impulsefxn()
    {
        GetComponent<Rigidbody>().AddForce(ImpulseVector*deltime*10f, ForceMode.Impulse);
        GetComponent<Rigidbody>().useGravity = true;
        counter += 1;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<DirectionTrack>().enabled = false;
        Debug.Log("Force ADDED ONCE");
    }
}