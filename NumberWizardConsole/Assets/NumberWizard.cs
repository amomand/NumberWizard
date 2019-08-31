using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max;
    int min;
    int guess;

    // Start is called before the first frame update
    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Greetings! Welcome to Number Wizard");
        Debug.Log("Pick a number. This is not a test");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius.");
            StartGame();
        }
    }

    private void NextGuess()
    {
        Debug.Log(guess);
        Debug.Log("Is it higher or lower than " + guess);
    }
}