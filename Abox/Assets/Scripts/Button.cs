using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject tekstBox;
    public Animator buttonanimation;
    public AudioSource punchSoundOne;
    public AudioSource punchSoundTwo;
    public int generateTone;


    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 3);
        if (generateTone == 1)

        {
            punchSoundOne.Play();

        }
        if (generateTone == 2)
        {
            punchSoundTwo.Play();

        }
        GlobalBoxes.BoxCount += 1;
        buttonanimation.Play("ANIMATION TIL BOX");



    }


}
