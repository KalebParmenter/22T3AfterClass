using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseIfStatement : MonoBehaviour
{
    public string myName = "Kaleb"; // a reference to the users name
    public string myCarColour = "White"; // a reference to the users car colour
    public bool likeCoffee = true; // does the user like coffee
    public int myAge = 22; // a reference to the age of the user

    // Start is called before the first frame update
    void Start()
    {
        //checks to see if the user likes coffee is true
        if(likeCoffee == true)
        {
            Debug.Log("likes coffee");
        }

        //checks tot see if my age is greater than 5, otherwise it is not
        if(myAge > 5)
        {
            Debug.Log("my age is greater than 5");
        }
        else
        {
            Debug.Log("my age is less than 5");
        }

        //checks to see if my age is greater than 29, else it checks to see if it is less than 26
        if(myAge > 29)
        {
            Debug.Log("age is greater than 29");
        }
        else if(myAge < 26)
        {
            Debug.Log("my age is less than 26");
        }

        //if my car colour is white
        // else if it checks to see if it is yellow and then checks if the user likes coffee
        // otherwise it checks if it purple otherwise it some other colour
        if(myCarColour == "White")
        {
            Debug.Log("car is white");

        }
        else if(myCarColour == "Yellow")
        {
            Debug.Log("my car is yellow");
            if(likeCoffee == false)
            {
                Debug.Log("dont like coffee");
            }
        }
        else
        {
            if(myCarColour == "Purple")
            {
                Debug.Log("car is colour is purple");
            }
            else
            {
                Debug.Log("car is some other colour");
            }
           
        }
    }

}
