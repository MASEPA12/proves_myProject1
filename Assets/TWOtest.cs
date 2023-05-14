using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWOtest: MonoBehaviour
{
    public float llargaria = 5f;
    public Vector3 direction = Vector3.forward;
    public LayerMask redLayerMask;
    public bool Dwncolisiona;
    public bool Upcolisiona;
    public bool Normalcolisiona;

    void Update()
    {
        Ray raigDwn = new Ray(transform.position - Vector3.up, transform.TransformDirection(direction * llargaria));
        Ray raigNormal = new Ray(transform.position, transform.TransformDirection(direction * llargaria));
        Ray raigUp = new Ray(transform.position + Vector3.up, transform.TransformDirection(direction * llargaria));
        
        RaycastHit hitDwn;
        RaycastHit hitNormal;
        RaycastHit hitUp;

        if (Physics.Raycast(raigUp, out hitUp, redLayerMask) && hitUp.distance < 0.5f)
        {
            Upcolisiona = true;
            Debug.Log($"estas a menos de 0.5 de s'objecte");
            Debug.DrawRay(raigUp.origin, raigUp.direction, Color.red);
        }
        else
        {
            Upcolisiona = false;
        }

        if (Physics.Raycast(raigNormal, out hitNormal, redLayerMask) && hitNormal.distance < 0.5f)
        {
            Normalcolisiona = true;
            Debug.Log($"estas a menos de 0.5 de s'objecte");
            Debug.DrawRay(raigNormal.origin, raigNormal.direction, Color.red);
        }
        else
        {
            Normalcolisiona = false;

        }

        if (Physics.Raycast(raigDwn, out hitDwn, redLayerMask) && hitDwn.distance < 0.5f) 
        {
            Dwncolisiona = true;
            Debug.Log($"estas a menos de 0.5 de s'objecte");
            Debug.DrawRay(raigDwn.origin, raigDwn.direction, Color.red);
        }
        else
        {
            Dwncolisiona = false;
        }
    }
    private void OnDrawGizmos()
    {
        
        if (Dwncolisiona)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position - Vector3.up, transform.TransformDirection(direction * llargaria));
        }
        else
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(transform.position - Vector3.up, transform.TransformDirection(direction * llargaria));
        }
        
        if (Upcolisiona)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position + Vector3.up, transform.TransformDirection(direction * llargaria));
        }
        else
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(transform.position + Vector3.up, transform.TransformDirection(direction * llargaria));
        }

        if (Normalcolisiona)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position, transform.TransformDirection(direction * llargaria));
        }
        else
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(transform.position, transform.TransformDirection(direction * llargaria));
        }
    }
}
