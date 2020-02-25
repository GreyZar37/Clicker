using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckIf : MonoBehaviour
{
    public int price;
    public string type;

    void Update()
    {

        if (type == "bleach")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfBleach)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }
        }

        if (type == "workers")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfWorkers)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }
        }









            if (type == "scissors")
            {
                if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfScissors)
                {
                    GetComponent<UnityEngine.UI.Button>().interactable = true;

                }
                else
                {
                    GetComponent<UnityEngine.UI.Button>().interactable = false;

                }


            }


        if (type == "storeSign")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfStoreSign)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }

        if (type == "speaker")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfSpeaker)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }

        if (type == "planks")
        {
         
            
            
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfPlanks)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }






        if (type == "WorkersUpgrade")
            {
                if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfWorkersUpgrade)
                {
                    GetComponent<UnityEngine.UI.Button>().interactable = true;

                }
                else
                {
                    GetComponent<UnityEngine.UI.Button>().interactable = false;

                }


            }

        if (type == "nails")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfNails)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }


        if (type == "Iron")
        {
            if (GlobalCash.CashCount >= GlobalAutoClicker.PriceOfIron)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;

            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;

            }


        }





    }
    }

