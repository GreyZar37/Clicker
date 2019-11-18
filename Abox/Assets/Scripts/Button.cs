using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject tekstBox;
    public Animator buttonanimation;


    public void ClickTheButton()
    {
        GlobalBoxes.BoxCount += 1;
        buttonanimation.Play("PopUpBox");
    }


}
