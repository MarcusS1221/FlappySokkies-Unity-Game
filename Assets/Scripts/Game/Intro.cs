using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public bool introDone = false;

    public GameObject Introgo;
    
    public void TriggerIntro()
    {
        introDone = true;
    }

    public void Update()
    {
        if (introDone == false)
        {
            Introgo.SetActive(true);
        }
        else
        {
            Introgo.SetActive(false);
        }
    }

}
