using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GlobalAutoClicker : MonoBehaviour
{
    public GameObject realBotten;
    public GameObject realText;

    

    public int currentCash; 
    public static int PriceOfBleach = 10;
    
    public static int PriceOfWorkers = 100;

    public static int PriceOfWorkersUpgrade = 1000;

    public static int PriceOfScissors = 500;

    public static int PriceOfStoreSign = 100;

    public static int PriceOfSpeaker = 10;


    public static int NumberOfBleachAutoClickers;
    public static int BleachPerSecond;

    public static int NumberOfScissorsAutoClicker;
    public static int WorkersPerSecond;

    public static int NumberOfScissorsAutoClickers; 
    public static int ScissorsPerSecond;

    public static int NumberOfStoreSignAutoClickers;
    public static int StoreSignPerSecond;

    public static int NumberOfSpeakerAutoClickers;
    public static int SpeakerPerSecond;



    public static int Mod = 1;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        
     
    }

    public void updatebuttongraphics(Text targetText,UnityEngine.UI.Button targetButton,string buttonText, string buttonType)
    {

        int price = 0; 

        if (buttonType == "bleach")
        {
            price = PriceOfBleach;
        }

        if (buttonType == "workers")
        {
            price = PriceOfWorkers;
        }
        if (buttonType == "scissors")
        {
            price = PriceOfScissors;
        }
        if (buttonType == "storeSign")
        {
            price = PriceOfStoreSign;
        }
        if (buttonType == "speaker")
        {
            price = PriceOfStoreSign;
        }





        targetText.text = buttonText + price;

/*
        if (currentCash >= PriceOfBleach)
        {
            targetButton.interactable = true;

        }
        else
        {
            targetButton.interactable = false;
        }
        */
    }

}
