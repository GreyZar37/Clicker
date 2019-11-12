using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GlobalAutoClicker : MonoBehaviour
{
    public GameObject realBotten;
    public GameObject realText;
    public int currentCash; 
    public static int autoValue = 50;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        
        realText.GetComponent<Text>().text = "Buy bleach - $" + autoValue;
        if (currentCash >= autoValue)
        {
            realBotten.GetComponent<UnityEngine.UI.Button>().interactable = true;

        } else
        {
            realBotten.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }
}
