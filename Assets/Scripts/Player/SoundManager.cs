using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioseat;

    public AudioSource audiosdie;


    public void PlaySoundEat()
    {
        audioseat.Play();
    }

    public void PlaySoundDie()
    {
        audiosdie.Play();
    }
}
