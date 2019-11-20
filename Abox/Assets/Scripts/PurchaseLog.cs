using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBox;
    public GameObject BuyBleach;
    public GameObject buyWorkers;
    public GameObject tekstboxtwo;
    public AudioSource sellSoundOne;
    public AudioSource sellSoundTwo;
    public GlobalAutoClicker gac;
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
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfBleach;
        GlobalAutoClicker.PriceOfBleach *= 2;
        GlobalAutoClicker.BleachPerSecond += 1;
        GlobalAutoClicker.NumberOfBleachAutoClickers += 1;
        gac.updatebuttongraphics(BuyBleach.GetComponentInChildren<Text>(), BuyBleach.GetComponent<UnityEngine.UI.Button>(), "Buy some bleach - $ ","bleach");


    }
        public void workers()


    {
       
        GlobalBoxes.BoxCount -= 1;
        GlobalCash.CashCount += 1;
        GlobalAutoClicker.NumberOfBleachAutoClickers += 1;


        AutoBox.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfWorkers;
        GlobalAutoClicker.PriceOfWorkers *= 2;
        GlobalAutoClicker.WorkersPerSecond += 1;
        GlobalAutoClicker.NumberOfBleachAutoClickers += 1;
        gac.updatebuttongraphics(buyWorkers.GetComponentInChildren<Text>(), buyWorkers.GetComponent<UnityEngine.UI.Button>(),"Buy workers - $ ", "workers");


    }





}
