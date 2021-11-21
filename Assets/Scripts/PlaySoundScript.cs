using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundScript : MonoBehaviour
{
    public AudioSource buttonSound;
   

    public void playSoundEffect() {
        buttonSound.Play();
    }
   
}
