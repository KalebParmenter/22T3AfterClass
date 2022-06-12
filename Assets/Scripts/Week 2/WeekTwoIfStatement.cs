using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfStatement : MonoBehaviour
{

    public string myName = "Kaleb"; // a variable to hold my name
    public bool likesCoffee = true; // does the user like coffee?
    public int myFavouriteNumber = 7; // the fav number of the user
    public float myFavouriteFloat = 5.5f; // the fav float of the user

    // Start is called before the first frame update
    void Start()
    {
        // anatomy of an if statement is:
        // if 
        // a condition i.e ( value inside of likescoffee is equal to true)
        // then do whatever is inside of the curly braces {}
        if(likesCoffee == true)
        {
            Debug.Log("Kaleb like Coffee");
        }

        // an example of a false condition being true
        if(likesCoffee == false)
        {
            Debug.Log("Kaleb dislike coffee");
        }

        // an example of a string condtion being true
        if(myName == "Stacey")
        {
            Debug.Log("Your name is stacey");

        }

        // an example of a string condition being true
        if(myName != "Stacey")
        {
            Debug.Log("Your name is Kaleb");
            //likesCoffee = false;
        }

        // an example of an int equaling exactly 7 being true
        if(myFavouriteNumber == 7)
        {
            Debug.Log("Is exactly 7");
        }

        // an example of a number being less than or equal to 5
        if(myFavouriteNumber <= 5)
        {
            Debug.Log("your number is less than 5");
        }

        // an example of a float being greater than 5
        if(myFavouriteFloat > 5 )
        {
            Debug.Log("your number is greater than 5");
        }

        // examples of multiple condtions
        if(myName == "Kaleb"  && likesCoffee == true)
        {
            Debug.Log("Kaleb likes coffee");
        }

        // an example of an && (and) statement where if both conditions are true
        // then execute the code
        if(myName != "Kaleb" && likesCoffee == false)
        {
            Debug.Log("Your name is not Kaleb and you dislikes coffee");
        }

        //an example of || (or) condition where if one of the condtions is true
        // then execute the code
        if(myFavouriteNumber < 4 || myFavouriteNumber > 6)
        {
            Debug.Log("My Fav number is less than 4 or my favourite number is greater than 6");
        }

        //an example of nesting multiple if statements with multiple conditions
        if(likesCoffee == true)
        {
            if(myName == "Kaleb")
            {
                Debug.Log("Kaleb likes coffee");
            }
            if(myName != "Kaleb")
            {
                Debug.Log("Not Kaleb");
                if(myFavouriteNumber > 4 && myFavouriteNumber < 7)
                {
                    Debug.Log("and my fav number is: " + myFavouriteNumber); 
                }
            }
        }
    }
}
