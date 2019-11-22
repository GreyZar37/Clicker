using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCrateThree : MonoBehaviour
{

    public bool CreatingBoxesThree = false;
    public static int BoxIncreaseThree = 1;
    public int InternalIncreaseThree;
    void Update()
    {
        BoxIncreaseThree = GlobalAutoClicker.ScissorsPerSecond;
        InternalIncreaseThree = BoxIncreaseThree;
        if (CreatingBoxesThree == false)
        {
            CreatingBoxesThree = true;
            StartCoroutine(CreateTheBoxThree());
        }
    }

    IEnumerator CreateTheBoxThree()
    {
        GlobalBoxes.BoxCount += InternalIncreaseThree;
        yield return new WaitForSeconds(1);
        CreatingBoxesThree = false;
    }
}
