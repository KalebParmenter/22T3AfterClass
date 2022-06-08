using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseStatement : MonoBehaviour
{
    public string myName = "Kaleb"; // hold a reference to the users name
    public string myCarColour = "White"; // holds a reference to the user car colour
    public bool likeCoffee = true; // hold a reference if the user likes coffee
    public int myAge = 22; // holds the user age

    // Start is called before the first frame update
    void Start()
    {
        //checks to see if the their name is kaleb
        // otherwise they are not kaleb
        if(myName == "Kaleb")
        {
            Debug.Log("You are Kaleb");
        }
        else
        {
            Debug.Log("You are not Kaleb");
        }

        //checks to see if their age is less than 22 and greater than 5
        // otherwise their age does not fall between these
        if(myAge < 22 && myAge < 5)
        {
            Debug.Log("your age does fall between 22 and 5");
        }
        else
        {
            Debug.Log("your age doesnt fall between 22 and 5");
        }

        //checks to see if their age is greater than 5
        if(myAge > 5)
        {
            Debug.Log("Age is greater than 5");
        }
        
        // checks to see if their age is less than 22 are example of single if statments
        if(myAge <22)
        {
            Debug.Log(" age is less than 29");
        }

        // an example of a nested if, else, if statments
        // if my name is not kaleb or my car colour is white
        if(myName != "Kaleb" || myCarColour == "White")
        {
            // do it 
            Debug.Log("Not Kaleb or Car colour is white");
            //if the user likes coffee, than log that out
            if(likeCoffee == true)
            {
                Debug.Log("Likes coffee");
            }
            else
            {
                //otherwise log out they dont like coffee
                Debug.Log("does not like coffee");
                //then check their age to see if they are older than 22
                //otherwise they must be younger
                if(myAge >22)
                {
                    Debug.Log("Your older than Kaleb :O");
                }
                else
                {
                    Debug.Log("Your younger than Kaleb");
                }
            }
        }
        
    }
}