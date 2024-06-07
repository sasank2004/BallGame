using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTrack : MonoBehaviour
{
    public Vector3 direction;
    Vector3 ImpulseVector = new Vector3(0f,0f,0f);
    //Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.Locked;
        //GameObject _ball = GameObject.FindGameObjectWithTag("Player");
        //rb = _ball.GetComponent<Rigidbody>();
        //rb.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        direction.x += Input.GetAxis("Mouse X") * 5f;
        direction.y += Input.GetAxis("Mouse Y") * 5f;
        direction.y = Mathf.Clamp(direction.y, 0f, 90f);
        direction.x = Mathf.Clamp(direction.x, -60f, 60f);
        transform.localRotation = (Quaternion.Euler(-direction.y, direction.x, 0));
    }
}