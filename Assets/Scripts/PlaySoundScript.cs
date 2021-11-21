using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundScript : MonoBehaviour
{
    public AudioSource buttonSound;
    public  AudioSource destroy;

    public void playSoundEffect() {
        buttonSound.Play();
    }
    /*public static void playSoundEffectDestroy()
    {
        destroy.Play();
    }*/

}
