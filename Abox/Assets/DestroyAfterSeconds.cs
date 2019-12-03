using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
   
    
    
    public int DestroyTime;
    void Start()
    {




        Destroy(gameObject, DestroyTime);
    }

    
    void Update()
    {
        
    }
}
