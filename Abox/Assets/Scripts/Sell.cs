using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public GameObject tekstbox;

    public void ClickTheButton()
    {
        GlobalBoxes.BoxCount -= 1;
        GlobalCash.CashCount += 1;
    }


}
