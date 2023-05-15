using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
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

    //rigidbody
    public Rigidbody rb;
    public test testScript;

    private void Start()
    {
        //transform.position = Vector3.up;
        rb = GetComponent<Rigidbody>();
        testScript = FindObjectOfType<test>();
    }
    void FixedUpdate()
    {
        //moviment
        horizontalInput = Input.GetAxis("Horizontal"); //movement front/back
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //asignam es centres per es capsulecast
        centre1 = transform.position + Vector3.down * altura;
        centre2 = transform.position + Vector3.up * altura;


        playerDirection = new Vector3(Input.GetAxisRaw("Vertical"),0, Input.GetAxisRaw("Horizontal"));

        RaycastHit hit;
                                    //sphere 1 , sphere2, en direcci a on, final capsula, capa que fa cas
        isColliding = Physics.CapsuleCast(centre1, centre2, radi, Vector3.forward , finalCapsula, layerMask1);

        if (isColliding == true)
        {
            Debug.Log("siiiii");
            //si est� colisionant, sa posici se restablecer per sa anterior inmediata
            transform.position = position;
        }
        else
        {
            Debug.Log("NOOO");
            //si no est� colisionant, sa posici se guardar per quan colisioni
            position = transform.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(centre1, radi);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(centre2, radi);
    }
}

