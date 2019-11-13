using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;


using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Phoneme[] phonemes;
    public static GameManager instance;
    //private static List<Phoneme> unansweredPhonemes;
     [SerializeField]
    public int currentPhoneme=-1;
    public AudioSource audioSrc;
    public AudioClip sh;
    public AudioClip v;
    public AudioClip u;
    public AudioClip z;
    [SerializeField]
    public string correctAnswer;
    [SerializeField]
    public int score=0;

    
    

    // private AudioClip currentPhonemeSound;

   public void Start()
    {
        instance=this;
        
        audioSrc = GetComponent<AudioSource>();
        SetCurrentPhoneme();
        SetOptions();
    }

   public void SetOptions ()
     {
         

         System.Random random = new System.Random();
         int randomNumber=random.Next(0, 6);
         int rightAnswer=random.Next(0, 3);
         int counter=0;
         
         GameObject.Find("boton"+randomNumber).GetComponentInChildren<Text>().text = phonemes[currentPhoneme].correctAnswers[rightAnswer];
         correctAnswer= "boton"+randomNumber;

         for(int i=0; i<phonemes[currentPhoneme].wrongAnswers.Length; i++)
         {
            if(i==randomNumber)
            {
                counter++;
            }
            GameObject.Find("boton"+counter).GetComponentInChildren<Text>().text = phonemes[currentPhoneme].wrongAnswers[i];
            counter++;
         }
    }

    public void SetCurrentPhoneme()
    {   
        currentPhoneme++;
        
        switch (currentPhoneme)
            {
                 case 0:
                    audioSrc.PlayOneShot(v);
                    break;
                 case 1:
                    audioSrc.PlayOneShot(sh);
                    break;
                 case 2:
                    audioSrc.PlayOneShot(u);
                    break;
                case 3:
                    audioSrc.PlayOneShot(z);
                    break;
            }

        //audioSrc.PlayOneShot(currentPhonemeSound);
       // currentPhonemeSound= currentPhoneme.phonemeSound;
       // sound.PlayOneShot(currentPhonemeSound);
    }

    

     public void ClickSound()
    {
        
        switch (currentPhoneme)
      {
          case 0:
                    audioSrc.PlayOneShot(v);
                    break;
                 case 1:
                    audioSrc.PlayOneShot(sh);
                    break;
                 case 2:
                    audioSrc.PlayOneShot(u);
                    break;
                case 3:
                    audioSrc.PlayOneShot(z);
                    break;
      }
        
    }

   



}
