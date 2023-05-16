using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpProjecte : MonoBehaviour
{
    /*//dins es game manager
    public bool appleGreenIsOn = false;
    public GameObject sliderPanelGreen;
    public float time; //(una variable que ja està feta dins s'escript de power ups)
    /* 
         - conexió amb sa speed (PlayerMovement.walkingForce)
         - 

     

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("appleGreen") && appleGreenIsOn == false)
        {
            Destroy(other.gameObject);
            StartCoroutine("SpeedPowerup(walkingForce)");
        }
    }

    //això anirà ficat dins;   --> canviar d'on agafa sa variable, l'ha de agafar de script "PowerUp"
    /* if(other.CompareTag(appleGreen) && gameManagerScript.appleGreenIsOn == false){ 
    public IEnumerator SpeedPowerUp(float speed,float durationOfPowerUp)
   {
        speed *= 2; //duble up the speed
        appleGreenIsOn = true;
        sliderPanelGreen.SetActive(true);

        time = durationOfPowerUp;
        StartCoroutine("Counter"); //--> ja està dins s'escript de power up

        yield return new WaitForSeconds(durationOfPowerUp);

        appleGreenIsOn = false;
   }
    private IEnumerator Counter(Slider slider, GameObject panelOfTheSlider, int numOfPowerUp)
    {   //it displays the seconds 

        slider.maxValue = time;//posam que es valor màxim de slider sigui es temps que ha d'esperar

        while (time > 0)
        {
            time -= 0.5f;
            slider.value = time;

            //as soon as the time is over, restablish the values
            if (time == 0)
            {
                panelOfTheSlider.SetActive(false);
                if(numOfPowerUp == 1)
                {
                    playerMovementScript.Scale(1.5f);
                }
                if(numOfPowerUp == 2)
                {
                    playerMovementScript.walkingForce = 0.5f; //restablish the speed
                }

            }
            yield return new WaitForSeconds(0.5f); //wait 30 seconds to low the number
        }

    }*/
}
