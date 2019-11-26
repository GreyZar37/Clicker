using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStoreTwo : MonoBehaviour
{

    public bool SellingBoxesStoreTwo = false;
    public static int SellIncreaseStoreTwo = 1;
    public int InternalSellIncreaseStoreTwo;
    public int SellBoxAmount;


    void Update()
    {
    
        
        SellBoxAmount =4*GlobalAutoClicker.NumberOfSpeakerAutoClickers;
        print("SellBoxAmount" + SellBoxAmount + "!");

        SellIncreaseStoreTwo = GlobalAutoClicker.SpeakerPerSecond;
        InternalSellIncreaseStoreTwo = SellIncreaseStoreTwo;
        if (SellingBoxesStoreTwo == false)
        {
            SellingBoxesStoreTwo = true;
            StartCoroutine(SellTheBoxStoreTwo());
        }

    }
            
        IEnumerator SellTheBoxStoreTwo()
        {
            if (GlobalBoxes.BoxCount >= SellBoxAmount)
            {
                GlobalCash.CashCount += InternalSellIncreaseStoreTwo;
                GlobalBoxes.BoxCount -= SellBoxAmount;
          
        } else if (GlobalBoxes.BoxCount > 0)
        {
            GlobalCash.CashCount += GlobalBoxes.BoxCount;
            GlobalBoxes.BoxCount = 0;
            print("I have taken " + GlobalBoxes.BoxCount + " boxes!");
        }
            
            yield return new WaitForSeconds(1);
            SellingBoxesStoreTwo = false;
        }

    







}
