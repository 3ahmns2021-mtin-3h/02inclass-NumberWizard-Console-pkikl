using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 100;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        WriteMessage();
        NextGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Key pressed Up");
            min = guess + 1;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Key pressed Down");
            max = guess - 1;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Key pressed Return");
            Debug.Log("Finished");
        }
    }

    private void WriteMessage()
    {
        Debug.Log("Number Wizard");
        Debug.Log("Pick a number between 1 and 100");
    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Guess " + guess);
        Debug.Log("Is it higher or lower than ... " + guess);
    }
}