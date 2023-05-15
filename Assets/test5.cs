using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test5 : MonoBehaviour
{
    //aa
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moviment
        horizontalInput = Input.GetAxis("Horizontal"); //movement front/back
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * 2 * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * 2 * Time.deltaTime * horizontalInput);
    }
}
