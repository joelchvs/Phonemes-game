using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Phoneme[] phonemes;
    private static List<Phoneme> unansweredPhonemes;
    private Phoneme currentPhoneme;

    void Start()
    {
        if(unansweredPhonemes == null || unansweredPhonemes.Count == 0)
        {
            unansweredPhonemes = phonemes.ToList<Phoneme>();
        }
        SetRandomPhoneme();
    }

    void SetRandomPhoneme()
    {
        int randomPhonemeIndex = Random.Range(0, unansweredPhonemes.Count);
        currentPhoneme = unansweredPhonemes[randomPhonemeIndex];

        unansweredPhonemes.RemoveAt(randomPhonemeIndex);
    }

}
