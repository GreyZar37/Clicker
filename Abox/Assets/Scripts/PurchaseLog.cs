using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBox;
    public GameObject AutoBoxTwo;
    public GameObject BuyBleach;
    public GameObject buyWorkers;
    public GameObject tekstboxtwo;
    public AudioSource sellSoundOne;
    public AudioSource sellSoundTwo;
    public GlobalAutoClicker gac;
    public GameObject buttonBetterWorkers;
    public Image Abox;
    public Sprite NewBoxOne;

    
    public int generateTone;
    public void betterWorkers()
    {
        GlobalAutoClicker.Mod = 2;

        buttonBetterWorkers.SetActive(false);

        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfWorkersUpgrade;
        



        generateTone = Random.Range(1, 3);
        if (generateTone == 1)

        {
            sellSoundOne.Play();

        }
        if (generateTone == 2)
        {
            sellSoundTwo.Play();

        }

        
    }
        
    public void StartAutoBox()
        
    {
                
        GlobalBoxes.BoxCount -= 1;
        GlobalCash.CashCount += 1;
        generateTone = Random.Range(1, 3);
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
        gac.updatebuttongraphics(BuyBleach.GetComponentInChildren<Text>(), BuyBleach.GetComponent<UnityEngine.UI.Button>(), "Buy some bleach\n$","bleach");


    }
        public void workers()
                
    {
       
        GlobalBoxes.BoxCount -= 2;
        GlobalCash.CashCount += 1;
        GlobalAutoClicker.NumberOfWorkersAutoClickers += 1;


        AutoBoxTwo.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfWorkers;
        GlobalAutoClicker.PriceOfWorkers *= 2;
        GlobalAutoClicker.WorkersPerSecond += 4 * GlobalAutoClicker.Mod;
        GlobalAutoClicker.NumberOfWorkersAutoClickers += 1;
        gac.updatebuttongraphics(buyWorkers.GetComponentInChildren<Text>(), buyWorkers.GetComponent<UnityEngine.UI.Button>(),"Buy workers\n$", "workers");
       
        generateTone = Random.Range(1, 3);
        if (generateTone == 1)

        {
            sellSoundOne.Play();

        }
        if (generateTone == 2)
        {
            sellSoundTwo.Play();

        }

        

    }

    public void NewBoxTexture()
    {
        Abox.sprite = NewBoxOne;
    }   
}
