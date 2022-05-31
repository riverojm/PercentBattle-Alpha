using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool LockYnegative;
    bool LockYpositive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 2.5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -2.5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-2.5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(2.5f * Time.deltaTime, 0, 0);
        }
        if (transform.eulerAngles.x > 270 && transform.eulerAngles.x < 220)
        {
            LockYpositive = true;
        }
        else
        {
            LockYpositive = false;
        }
        if (transform.eulerAngles.x > 83 && transform.eulerAngles.x < 90)
        {
            LockYnegative = true;
        }
        else
        {
            LockYpositive = false;
        }
        if (LockYnegative)
        {
            if (Input.GetAxis("Mouse Y")>0)
            {
                transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"),0,0);
            }
        }
        else
        {
            if (!LockYpositive) transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y") /2,0,0);
        }
        if (LockYpositive)
        {
            if (Input.GetAxis("Mouse Y") <0)
            {
                transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0, 0);
            }
        }
        else
        {
            if (!LockYnegative)transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y")/2,0,0);
        }
        transform.eulerAngles += new Vector3(0, Input.GetAxis("Mouse X"), 0);
    }
}
