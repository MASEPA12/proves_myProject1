using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    /*Vector2 inputVector = gameInput.GetMovementVectorNormalized();

    Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
    private void Update()
    {
            float moveDistance = moveSpeed * Time.deltaTime;
            float playerRadius = .7f;
            float playerHeight = 2f;
            bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight,
                playerRadius, moveDir, moveDistance);
        if (!canMove)
                {
                    // Si nos estamos chocando, en el caso en que nos estemos moviendo en diagonal, vamos a intentar movernos en una dirección
                    // Probar dirección X
                    Vector3 moveDirX = new Vector3(moveDir.x, 0, 0).normalized; // Importante normalizar para que no vaya más lento (moveDir ya estaba normalizado y este es el caso en que nos movemos en diagonal)
                    canMove = (moveDir.x< -0.5f || moveDir.x> 0.5f) && !Physics.CapsuleCast(transform.position, transform.position + Vector3.up* playerHeight,
                        playerRadius, moveDirX, moveDistance);

                    if (canMove)
                    {
                        // Nos movemos solo en X
                        moveDir = moveDirX;
                    }
                    else
        {
            // No nos podemos mover en X
            // Probar dirección Z
            Vector3 moveDirZ = new Vector3(0, 0, moveDir.z).normalized; // Importante normalizar para que no vaya más lento (moveDir ya estaba normalizado y este es el caso en que nos movemos en diagonal)
            canMove = (moveDir.z < -0.5f  moveDir.z > 0.5f) && !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight,
                playerRadius, moveDirZ, moveDistance);

            if (canMove)
            {
                // Nos movemos solo en Z
                moveDir = moveDirZ;
            }
        }

                }
        if (canMove)
        {
            transform.position += moveDir * moveDistance;
        }

            }
    }*/
    
}



