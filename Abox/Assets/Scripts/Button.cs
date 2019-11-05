using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject tekstBox;

    public void ClickTheButton()
    {
        GlobalBoxes.BoxCount += 1; 
    }


}
