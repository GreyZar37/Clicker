using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrate : MonoBehaviour
{

    public bool CreatingBoxes = false;
    public static int BoxIncrease = 1;
    public int InternalIncrease;
        void Update()
    {
        BoxIncrease = GlobalAutoClicker.makePerSec;
        InternalIncrease = BoxIncrease; 
        if (CreatingBoxes == false)
        {
            CreatingBoxes = true;
            StartCoroutine(CreateTheBox());
        }
    }

    IEnumerator CreateTheBox()
    {
        GlobalBoxes.BoxCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingBoxes = false;
    }
}
