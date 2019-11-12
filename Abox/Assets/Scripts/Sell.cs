using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public GameObject tekstbox;

    public void ClickTheButton()
    {
        if (GlobalBoxes.BoxCount == 0)
        {

        }
        else
        {
            GlobalBoxes.BoxCount -= 1;
            GlobalCash.CashCount += 1;
        }
       
    }


}
