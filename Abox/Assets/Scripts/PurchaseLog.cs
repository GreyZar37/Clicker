using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBox;
    public GameObject tekstbox;
    public AudioSource sellSoundOne;
    public AudioSource sellSoundTwo;
    public int generateTone;

    public void StartAutoBox()


    {
        generateTone = Random.Range(1, 3);
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

        AutoBox.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.autoValue;
        GlobalAutoClicker.autoValue *= 2;
        GlobalAutoClicker.makePerSec += 1;
        GlobalAutoClicker.numberOfAutoClicker += 1;


    }
    



}
