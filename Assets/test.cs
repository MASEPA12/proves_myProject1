using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Vector3 centre;
    public Vector3 halfExtents;
    public bool isInTheBox = false;
    public LayerMask layerMask2;

    private void Start()
    {
    }

    private void Update()
    {
        centre = transform.position; //li sumam un pq estigui centrat es cnetre de sa box

        if(Physics.CheckBox(centre, halfExtents,Quaternion.identity,layerMask2) == true) //if something is inside the box...
        {
            isInTheBox = true;
            Debug.Log("SOMETHING IS INSIDE THE BOX");
        }
        else
        {
            isInTheBox = false;
            //Debug.Log("NOTHING IS IN THE BOX");

        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(centre, halfExtents);
    }
}



