using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Start is called before the first frame update
    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        max += 1;
        guess = (max + min) / 2;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = (max + min) / 2;
    }
}