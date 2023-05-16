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

    //aa
    private float speed = 50f;
    private float verticalInput;
    private float horizontalInput;

    //sss
    public bool isColliding;
    public bool isCollidingSphere;

    //rigidbody
    public Rigidbody rb;

    private void Start()
    {
        //transform.position = Vector3.up;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        RaycastHit hit;
        //moviment
        horizontalInput = Input.GetAxis("Horizontal"); //movement front/back
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //asignam es centres per es capsulecast
        centre1 = transform.position + Vector3.down * altura;
        centre2 = transform.position + Vector3.up * altura;
        playerDirection = new Vector3(verticalInput, 0, horizontalInput);

                                    //sphere 1 , sphere2, en direcció a on, final capsula, capa que farà cas
       // isColliding = Physics.CapsuleCast(centre1, centre2, radi, transform.forward,out hit, finalCapsula, layerMask1);

        isCollidingSphere = Physics.SphereCast(centre1, radi, playerDirection, out hit, finalCapsula, layerMask1);

        if (isCollidingSphere == true && (hit.distance < 0.5f || hit.distance > -0.5f))
        {
            Debug.Log("AAAAAA");
            
                //vol anar cap endavant
            if (playerDirection.x > 0)
            {
                playerDirection.x = 0;
                Debug.Log("GOING FRONT");
                playerDirection.z = 1;
            }
                //si vol anar cap enrrere
            if (playerDirection.x <= 0)
            {
                playerDirection.x = 0;
                playerDirection.z = 1;

                Debug.Log("GOING FRONT");
            }
        }
        else
        {
            Debug.Log("NOOO");
            //si no està colisionant, sa posició se guardarà per quan colisioni
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.magenta;
        //Gizmos.DrawWireSphere(centre1,radi);
        
       /* Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(centre2,radi);*/
    }
}
