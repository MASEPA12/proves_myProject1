using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public Transform point1;
    public Transform point2;
    public bool goingToend;
    public Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * force;
        rb.AddForce(transform.forward, ForceMode.Impulse) ;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(goingToend == true)
        {
            Move(point1);
        }
        if(goingToend == false)
        {
            Move(point2);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "start")
        {
            goingToend = true;

        }else if(other.gameObject.name == "end")
        {
            goingToend = false;
        }
        
    }

    public void Move(Transform point)
    {
        rb.velocity = point.forward * force;
        direction = point.forward;
    }
}
