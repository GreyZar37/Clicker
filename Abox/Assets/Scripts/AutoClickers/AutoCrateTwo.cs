using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrateTwo : MonoBehaviour
{

    public bool CreatingBoxesTwo = false;
    public static int BoxIncreaseTwo = 1;
    public int InternalIncreaseTwo;
    void Update()
    {
        BoxIncreaseTwo = GlobalAutoClicker.WorkersPerSecond;
        InternalIncreaseTwo = BoxIncreaseTwo;
        if (CreatingBoxesTwo == false)
        {
            CreatingBoxesTwo = true;
            StartCoroutine(CreateTheBoxTwo());
        }
    }

    IEnumerator CreateTheBoxTwo()
    {
        GlobalBoxes.BoxCount += InternalIncreaseTwo;
        yield return new WaitForSeconds(1);
        CreatingBoxesTwo = false;
    }
}
