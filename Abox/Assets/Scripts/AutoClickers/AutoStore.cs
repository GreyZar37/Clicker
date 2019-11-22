using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStore : MonoBehaviour
{

    public bool SellingBoxes = false;
    public static int SellIncrease = 1;
    public int InternalSellIncrease;
    void Update()
    {




        SellIncrease = GlobalAutoClicker.StoreSignPerSecond;
        InternalSellIncrease = SellIncrease;
        if (SellingBoxes == false)
        {
            SellingBoxes = true;
            StartCoroutine(SellTheBox());
        }

    }
        IEnumerator SellTheBox()
        {
            if (GlobalBoxes.BoxCount >= GlobalAutoClicker.NumberOfStoreSignAutoClickers)
            {
                GlobalCash.CashCount += InternalSellIncrease;
                GlobalBoxes.BoxCount -= GlobalAutoClicker.NumberOfStoreSignAutoClickers; 
            } else if (GlobalBoxes.BoxCount > 0)
        {
            GlobalCash.CashCount += GlobalBoxes.BoxCount;
            GlobalBoxes.BoxCount = 0;
        }
            
            yield return new WaitForSeconds(1);
            SellingBoxes = false;
        }

    







}
