using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip sonido1;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;

    //public int[] sonidos;
    
    // public Sonido()
    // {
    //     sonidos = new int[4];
    //     for (int i=0; i<sonidos.Length; i++)
    //     {
    //         sonidos[i]=i;
    //     }
    // }
    
    public void ClickSound()
    {
        

        sonido.PlayOneShot(one);
    }
}
