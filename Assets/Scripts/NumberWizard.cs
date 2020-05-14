using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;
    //List<int> previousGuess = new List<int>();
    [SerializeField] TextMeshProUGUI guessText;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        guess = Random.Range(max, min);
        guessText.text = guess.ToString();
    }

    void NextGuess()
    {
        max = max + 1;
        guess = Random.Range(max, min);
        guessText.text = guess.ToString();
        //previousGuess.Add(guess);

    }

    public void OnPressHigher()
    {
        max = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        min = guess;
        NextGuess();
    }

}