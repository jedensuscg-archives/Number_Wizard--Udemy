using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    int max;
    [SerializeField] int min;
    int numberOfGuesses;
    int guess;
    bool showHistory = false;
    string guessHistory;
    [SerializeField] TextMeshProUGUI guessCountText;
    [SerializeField] Text guessHistoryText;
    List<int> previousGuess = new List<int>();
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] Text guessHeader;
    [SerializeField] Text guessSubHeader;
    [SerializeField]


    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = StartLogic.newMax;
        guessHistoryText.enabled = false;
        max = max;
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        previousGuess.Add(guess);
        numberOfGuesses += 1;
        guessHistory = (string.Join(System.Environment.NewLine, previousGuess));
        guessHistoryText.text = guessHistory.ToString();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        while (true)
        {
            if(previousGuess.Contains(guess))
            {
                if(max-min <= 1)
                {
                    guessHeader.fontSize = 32;
                    guessHeader.text =  $"YOUR NUMBER MUST BE {guess}, OR YOU FORGOT YOUR NUMBER!";
                    guessSubHeader.text = "BECAUSE I AM OUT OF NUMBERS TO GUESS.";
                    
                    break;
                }
                else
                {
                    guess = Random.Range(min, max + 1);
                    Debug.Log("DUPLICATE ANSWER");
                }
            }
            else
            {
                break;
            }
            
        }
        Debug.Log(max - min);
        numberOfGuesses += 1;
        guessText.text = guess.ToString();
        guessCountText.text = numberOfGuesses.ToString();
        previousGuess.Add(guess);

        guessHistory = (string.Join(System.Environment.NewLine, previousGuess));
        guessHistoryText.text = guessHistory.ToString();

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

    public void displayHistory()
    {
        showHistory = !showHistory;
        if(showHistory)
        {
            guessHistoryText.enabled = true;
        }
        else
        {
            guessHistoryText.enabled = false;
        }
    }

    
}