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
            if (GlobalBoxes.BoxCount >= 1)
            {
                GlobalCash.CashCount += InternalSellIncrease;
                GlobalBoxes.BoxCount -= 1; 
            }
            
            yield return new WaitForSeconds(1);
            SellingBoxes = false;
        }

    







}
