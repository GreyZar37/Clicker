using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public GameObject tekstbox;
    public AudioSource sellSoundOne;
    public AudioSource sellSoundTwo;
    public int generateTone; 
    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalBoxes.BoxCount == 0)
        {

        }
        else
        {
            GlobalBoxes.BoxCount -= 1;
            GlobalCash.CashCount += 1;
            if (generateTone == 1)
           
            {
                sellSoundOne.Play();

            }
            if (generateTone == 2)
            {
                sellSoundTwo.Play();

            }
        }


    }


}
