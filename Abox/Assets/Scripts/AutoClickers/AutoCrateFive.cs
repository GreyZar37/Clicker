using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrateFive : MonoBehaviour
{

    public bool CreatingBoxesFive = false;
    public static int BoxIncreaseFive = 1;
    public int InternalIncreaseFive;
    void Update()
    {
        BoxIncreaseFive = GlobalAutoClicker.NailsPerSecond;
        InternalIncreaseFive = BoxIncreaseFive;
        if (CreatingBoxesFive == false)
        {
            CreatingBoxesFive = true;
            StartCoroutine(CreateTheBoxFive());
        }
    }

    IEnumerator CreateTheBoxFive()
    {
        GlobalBoxes.BoxCount += InternalIncreaseFive;
        yield return new WaitForSeconds(1);
        CreatingBoxesFive = false;
    }
}
