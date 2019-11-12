using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalBoxes : MonoBehaviour
{

    public static int BoxCount;
    public GameObject BoxDisplay;
    public int InternalBox; 

    void Update()
    {
        InternalBox = BoxCount; 
        BoxDisplay.GetComponent<Text>().text = "Boxes " + InternalBox; 
    }
}
