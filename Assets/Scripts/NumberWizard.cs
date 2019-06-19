using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (min + max) / 2;
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    //Debug.Log("Higher Value");
        //    min = guess;
        //    NextGuessNumber();
        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    //Debug.Log("Lower Value");
        //    max = guess;
        //    NextGuessNumber();
        //}
        //else if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    Debug.Log("Correct Value");
        //    StartGame();
        //}

        
    }

    public void GetHigher()
    {
        min = guess;
        NextGuessNumber();
    }

    public void GetLower()
    {
        max = guess;
        NextGuessNumber();
    }

    void NextGuessNumber()
    {
        guess = (min + max) / 2;
       // Debug.Log("Is your number higher or lower than the guessed number " + guess);
    }
}
