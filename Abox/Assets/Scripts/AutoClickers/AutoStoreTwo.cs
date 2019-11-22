using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStoreTwo : MonoBehaviour
{

    public bool SellingBoxesTwo = false;
    public static int SellIncreaseTwo = 1;
    public int InternalSellIncreaseTwo;
    public int SellBoxAmount;


    void Update()
    {
    
        
        SellBoxAmount = GlobalAutoClicker.SpeakerPerSecond + GlobalAutoClicker.NumberOfSpeakerAutoClickers;


        SellIncreaseTwo = GlobalAutoClicker.SpeakerPerSecond;
        InternalSellIncreaseTwo = SellIncreaseTwo;
        if (SellingBoxesTwo == false)
        {
            SellingBoxesTwo = true;
            StartCoroutine(SellTheBoxTwo());
        }

    }
            
        IEnumerator SellTheBoxTwo()
        {
            if (GlobalBoxes.BoxCount >= SellBoxAmount)
            {
                GlobalCash.CashCount += InternalSellIncreaseTwo;
                GlobalBoxes.BoxCount -= SellBoxAmount; 
            } else if (GlobalBoxes.BoxCount > 0)
        {
            GlobalCash.CashCount += GlobalBoxes.BoxCount;
            GlobalBoxes.BoxCount = 0;
            
        }
            
            yield return new WaitForSeconds(1);
            SellingBoxesTwo = false;
        }

    







}
