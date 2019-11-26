using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBox;
    public GameObject AutoBoxTwo;
    public GameObject AutoBoxThree;
    public GameObject AutoBoxFour;
    public GameObject BuyBleach;
    public GameObject AutoStore;
    public GameObject AutoStoreTwo;
  
    public GameObject buyWorkers;
    public GameObject tekstboxtwo;

    public GameObject buyScissors;
    public GameObject tekstBoxThree;

    public GameObject buyStoreSign;
    public GameObject tekstBoxStore;

    public GameObject buySpeaker;
    public GameObject tekstBoxStoreTwo;


    public GameObject buyPlanks;
    public GameObject tekstBoxStoreFour;

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
        gac.updatebuttongraphics(BuyBleach.GetComponentInChildren<Text>(), BuyBleach.GetComponent<UnityEngine.UI.Button>(), "Buy bleach\n$","bleach");


    }
        public void workers()
                
    {
       
        GlobalBoxes.BoxCount -= 2;
        GlobalCash.CashCount += 1;
        GlobalAutoClicker.NumberOfScissorsAutoClicker += 1;


        AutoBoxTwo.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfWorkers;
        GlobalAutoClicker.PriceOfWorkers *= 2;
        GlobalAutoClicker.WorkersPerSecond += 4 * GlobalAutoClicker.Mod;
        GlobalAutoClicker.NumberOfScissorsAutoClicker += 1;
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
   
    public void Scissors()

 
    {

        GlobalBoxes.BoxCount -= 2;
        GlobalCash.CashCount += 1;
        GlobalAutoClicker.NumberOfScissorsAutoClickers += 1;


        AutoBoxThree.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfScissors;
        GlobalAutoClicker.PriceOfScissors *= 2;
        GlobalAutoClicker.ScissorsPerSecond += 8;
        GlobalAutoClicker.NumberOfScissorsAutoClicker += 1;
        gac.updatebuttongraphics(buyScissors.GetComponentInChildren<Text>(), buyScissors.GetComponent<UnityEngine.UI.Button>(), "Buy Scissors\n$", "scissors");

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


    public void StoreSign()


    {
        AutoStore.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfStoreSign;
        GlobalAutoClicker.PriceOfStoreSign *= 2;
        GlobalAutoClicker.StoreSignPerSecond += 1;
        GlobalAutoClicker.NumberOfStoreSignAutoClickers += 1;
        gac.updatebuttongraphics(buyStoreSign.GetComponentInChildren<Text>(), buyStoreSign.GetComponent<UnityEngine.UI.Button>(), "Buy store sign\n$", "storeSign");

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


    public void Speaker()


    {
        AutoStoreTwo.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfSpeaker;
        GlobalAutoClicker.PriceOfSpeaker *= 2;
        GlobalAutoClicker.SpeakerPerSecond += 4;
        GlobalAutoClicker.NumberOfSpeakerAutoClickers += 1;
        gac.updatebuttongraphics(buySpeaker.GetComponentInChildren<Text>(), buySpeaker.GetComponent<UnityEngine.UI.Button>(), "Buy speaker\n$", "speaker");

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

    public void planks()

    {

        GlobalBoxes.BoxCount -= 2;
        GlobalCash.CashCount += 1;
        GlobalAutoClicker.NumberOfPlanksAutoClickers += 1;


        AutoBoxFour.SetActive(true);
        GlobalCash.CashCount -= GlobalAutoClicker.PriceOfPlanks;
        GlobalAutoClicker.PriceOfPlanks *= 2;
        GlobalAutoClicker.PlanksPerSecond += 12;
        GlobalAutoClicker.NumberOfPlanksAutoClickers += 1;
        gac.updatebuttongraphics(buyPlanks.GetComponentInChildren<Text>(), buyPlanks.GetComponent<UnityEngine.UI.Button>(), "Buy planks\n$", "planks");

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
