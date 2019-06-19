using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;

    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuessNumber();
    }

    public void GetHigher()
    {
        min = guess + 1;
        NextGuessNumber();
    }

    public void GetLower()
    {
        max = guess - 1;
        NextGuessNumber();
    }

    void NextGuessNumber()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
