using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpProjecte : MonoBehaviour
{
    //dins es game manager
    public bool appleGreenIsOn = false;
    public GameObject sliderPanelGreen; 
    /* 
         - conexió amb sa speed (PlayerMovement.walkingForce)
         - 

     */

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("appleGreen") && appleGreenIsOn == false)
        {
            Destroy(other.gameObject);

        }
    }

    //això anirà ficat dins;   --> canviar d'on agafa sa variable, l'ha de agafar de script "PoweUp"
    /* if(other.CompareTag(appleGreen) && gameManagerScript.appleGreenIsOn == false){ */
    public IEnumerator SpeedPowerUp(float speed,float durationOfPowerUp)
   {
        speed *= 2; //duble up the speed
        appleGreenIsOn = true;
        sliderPanelGreen.SetActive(true);

        yield return new WaitForSeconds(durationOfPowerUp);

        appleGreenIsOn = false;
   }

}
