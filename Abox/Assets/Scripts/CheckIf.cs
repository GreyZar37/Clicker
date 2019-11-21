﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckIf : MonoBehaviour
{
    public int price;
    public string type;

    void Update()
    {

        if (type == "bleach")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfBleach)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }
        }

        if (type == "workers")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfWorkers)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }
        
        if (type == "WorkersUpgrade")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfWorkersUpgrade)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }



    }
}
