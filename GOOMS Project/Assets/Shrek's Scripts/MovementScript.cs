using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed;
    public VirtualJoystick joystick;
    private Rigidbody rb;

    private Animation anim;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementSpeed = 8f;
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jMovement = joystick.InputDirection;
        float x = jMovement.x;
        float y = jMovement.z;
        
        rb.velocity = jMovement * 1;

        if(x!= 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg,
                transform.eulerAngles.z);
        }

        /*
        if( x != 0 || y != 0)
        {
            anim.Play("Insert File Name Here");
        } else
        {
            anim.Play("Insert File Name Here");
        }*/
    }
}
