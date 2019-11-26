using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrateFour : MonoBehaviour
{

    public bool CreatingBoxesFour = false;
    public static int BoxIncreaseFour = 1;
    public int InternalIncreaseFour;
    void Update()
    {
        BoxIncreaseFour = GlobalAutoClicker.PlanksPerSecond;
        InternalIncreaseFour = BoxIncreaseFour;
        if (CreatingBoxesFour == false)
        {
            CreatingBoxesFour = true;
            StartCoroutine(CreateTheBoxFour());
        }
    }

    IEnumerator CreateTheBoxFour()
    {
        GlobalBoxes.BoxCount += InternalIncreaseFour;
        yield return new WaitForSeconds(1);
        CreatingBoxesFour = false;
    }
}
