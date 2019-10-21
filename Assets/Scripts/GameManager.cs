using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;


using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Phoneme[] phonemes;
    //private static List<Phoneme> unansweredPhonemes;
    private int currentPhoneme=-1;
    public AudioSource audioSrc;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;

     [SerializeField]
    // private AudioClip currentPhonemeSound;

    void Start()
    {
        
        audioSrc = GetComponent<AudioSource>();
        SetCurrentPhoneme();
        SetOptions();
    }

    void SetOptions ()
     {
            //int [] buttonNames = new int[5]  { 99,  98, 92, 97, 95};

         System.Random random = new System.Random();
         int randomNumber=random.Next(0, 6);
         int rightAnswer=random.Next(0, 3);
         int counter=0;
         //string hola=phonemes[currentPhoneme].correctAnswers[0];
         
        GameObject.Find("boton"+randomNumber).GetComponentInChildren<Text>().text = phonemes[currentPhoneme].correctAnswers[rightAnswer];


        //  for (int i = (phonemes[currentPhoneme].wrongAnswers.Length) - 1; i > 0; i--)  
        // {  
        //     int j =random.Next(0, i);
        //     string temp =phonemes[currentPhoneme].wrongAnswers[i];  
        //     phonemes[currentPhoneme].wrongAnswers[i] =phonemes[currentPhoneme].wrongAnswers[j];
        //     phonemes[currentPhoneme].wrongAnswers[j]=temp;
        // } 
   
        for(int i=0; i<=phonemes[currentPhoneme].wrongAnswers.Length; i++)
        {
            if(i==randomNumber)
            {
                i++;
            }
            GameObject.Find("boton"+i).GetComponentInChildren<Text>().text = phonemes[currentPhoneme].wrongAnswers[counter];
            counter++;
        }


            
     

    //     GameObject.Find("boton1").GetComponentInChildren<Text>().text = "uno";
    //     GameObject.Find("boton2").GetComponentInChildren<Text>().text = "dos";
    //     GameObject.Find("boton3").GetComponentInChildren<Text>().text = "tres";
    //     GameObject.Find("boton4").GetComponentInChildren<Text>().text = "cuatro";
    //     GameObject.Find("boton5").GetComponentInChildren<Text>().text = "cinco";
    //     GameObject.Find("boton6").GetComponentInChildren<Text>().text = "seis";
        
    
    }

    void SetCurrentPhoneme()
    {   
        currentPhoneme++;
        
    // System.Random random = new System.Random();

      //  currentPhoneme=random.Next(0, 4);
        switch (currentPhoneme)
            {
                 case 0:
                    audioSrc.PlayOneShot(one);
                    break;
                 case 1:
                    audioSrc.PlayOneShot(two);
                    break;
                 case 2:
                    audioSrc.PlayOneShot(three);
                    break;
                case 3:
                    audioSrc.PlayOneShot(four);
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
              audioSrc.PlayOneShot(one);
              break;
          case 1:
              audioSrc.PlayOneShot(two);
              break;
          case 2:
              audioSrc.PlayOneShot(three);
              break;
          case 3:
              audioSrc.PlayOneShot(four);
              break;
      }
        
    }

    public void clickButton0()
    {
        if(String.Equals(GameObject.Find("boton0").GetComponentInChildren<Text>().text,"0"))
        {
            Debug.Log("CORRECTO!!!!!!!!");
        }
    }

   public bool checkAnswer (string answer)
   {
       bool isCorrect = false;

       for (int i = 0; i< phonemes[currentPhoneme].correctAnswers.Length; i++)
       {
           if (String.Equals(answer, phonemes[currentPhoneme].correctAnswers[i]))
           {
               isCorrect= true;
               break;
           }
       }
       return isCorrect;
   }

}
