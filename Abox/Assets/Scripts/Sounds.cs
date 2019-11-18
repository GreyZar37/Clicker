using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioSource punch; 

    public void Playpunch()
    {
        punch.Play();
    }

}
