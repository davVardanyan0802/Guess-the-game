using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessNumber : MonoBehaviour
{

    public InputField input;
    public Text infotext;
    private int guessnumber;
    private int usersguess;
    // Start is called before the first frame update
    void Start()
    {
        guessnumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        usersguess = int.Parse(input.text);
        if(usersguess == guessnumber)
        {
            infotext.text = "You guessed the number";
        }else if (usersguess > guessnumber)
        {
            infotext.text = "Your guess is higher";
        }else if (usersguess < guessnumber)
        {
            infotext.text = "Your guess is lower";
        }

        input.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
