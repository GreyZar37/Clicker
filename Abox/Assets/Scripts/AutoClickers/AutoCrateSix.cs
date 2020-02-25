using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrateSix : MonoBehaviour
{

    public bool CreatingBoxesSix = false;
    public static int BoxIncreaseSix = 1;
    public int InternalIncreaseSix;
    void Update()
    {
        BoxIncreaseSix = GlobalAutoClicker.IronPerSecond;
        InternalIncreaseSix = BoxIncreaseSix;
        if (CreatingBoxesSix == false)
        {
            CreatingBoxesSix = true;
            StartCoroutine(CreateTheBoxSix());
        }
    }

    IEnumerator CreateTheBoxSix()
    {
        GlobalBoxes.BoxCount += InternalIncreaseSix;
        yield return new WaitForSeconds(1);
        CreatingBoxesSix = false;
    }
}
