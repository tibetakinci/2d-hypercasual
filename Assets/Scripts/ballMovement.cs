using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float ballSpeed;
    private bool right = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 8.63 && right)
        {
            //Debug.Log(transform.position.x);
            transform.Translate(Vector3.right * ballSpeed);
        }
        else
        {
            right = false;
        }

        if (transform.position.x > -8.63 && !right)
        {
            //Debug.Log(transform.position.x);
            transform.Translate(Vector3.left * ballSpeed);
        }
        else
        {
            right = true;
        }

        if (Input.GetKeyDown("space"))
        {
            if (right)
            {
                right = false;
            }
            else
            {
                right = true;
            }
        }
    }
}
