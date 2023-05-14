using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
    private Vector3 centre1;
    private Vector3 centre2;

    public float radi;
    public LayerMask layerMask1;

    public float altura;
    public float finalCapsula;

    public Vector3 playerDirection;

    private Vector3 position;

    //aa
    private float speed = 50f;
    private float turnSpeed = 100f;
    private float rotationInput;
    private float verticalInput;
    private float horizontalInput;

    //sss
    public bool isColliding;
    public bool sweepTest1;

    //rigidbody
    public Rigidbody rb;
    private void Start()
    {
        transform.position = Vector3.up;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        RaycastHit hit;
        //moviment
        horizontalInput = Input.GetAxis("Horizontal"); //movement front/back
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //asignam es centres per es capsulecast
        centre1 = transform.position + Vector3.down * altura;
        centre2 = transform.position + Vector3.up * altura;
        playerDirection = new Vector3(verticalInput, 0, horizontalInput);

                                    //sphere 1 , sphere2, en direcció a on, final capsula, capa que farà cas
        isColliding = Physics.CapsuleCast(centre1, centre2, radi, playerDirection, finalCapsula, layerMask1);
        
        sweepTest1 = rb.SweepTest(playerDirection, out hit, finalCapsula);


        if (sweepTest1 == true)// si aqui on ha de anar ha de colisionar
        {
            Debug.Log("colisionaras proximamente");
        }

        if (isColliding == true)
        {
            Debug.Log("siiiii");
            //si està colisionant, sa posició se restablecerà per sa anterior inmediata
            transform.position = position;

        }
        else
        {
            Debug.Log("NOOO");
            //si no està colisionant, sa posició se guardarà per quan colisioni
            position = transform.position;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(centre1,radi);
        
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(centre2,radi);
    }
}
