using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public GameObject tekstbox;
    public AudioSource sellSoundOne;
    public AudioSource sellSoundTwo;
    public int generateTone;
    public GameObject ParticlePrefab;
    
    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalBoxes.BoxCount == 0)
        {

        }
        else
        {
            GameObject Spawn = Instantiate(ParticlePrefab, new Vector3(148.9f, 66, -353.4f),Quaternion.Euler(-90,0,0));
            Spawn.GetComponent<ParticleSystem>().emission.SetBursts((new ParticleSystem.Burst[] { new ParticleSystem.Burst(0.0f, 1, 1) }));

            

            GlobalBoxes.BoxCount -= 1;
            GlobalCash.CashCount += 1;
            if (generateTone == 1)
           
            {
                sellSoundOne.Play();

            }
            if (generateTone == 2)
            {
                sellSoundTwo.Play();

            }
        }


    }


}
