﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBox;
    public void StartAutoBox()
    {
        AutoBox.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.autoValue;
        GlobalAutoClicker.autoValue *= 2;
    }
    



}
