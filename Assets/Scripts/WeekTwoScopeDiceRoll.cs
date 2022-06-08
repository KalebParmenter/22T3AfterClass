using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoScopeDiceRoll : MonoBehaviour
{
    public int myDiceRoll = 0; // the current number the dice is
    public int myMinDiceRoll = 0; //the minimum number the dice could possible be
    public int myMaxDiceRoll = 6; // max number the dice could be 
    [Tooltip("The key used for rolling the dice")] 
    public KeyCode rollInputKey; // the input we will use to start rolling our dice

    // Start is called before the first frame update
    void Start()
    {
        // an example of scope, this variable myCurrentDiceRoll
        // only exists withtin these start{} if you try to access
        // it on a different level/ different layer of {} then it wont be accessible
        int myCurrentDiceRoll = 0;
        
        if(myCurrentDiceRoll > 0)
        {
            myCurrentDiceRoll = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //checks to see if the input key is pressed
        //if it is get a random number for my dice roll
        if (Input.GetKeyDown(rollInputKey))
        {
            // lets create a temporary variable to hold my current dice roll
            int myCurrentDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll + 1);
            myDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll);
            Debug.Log("My dice roll is: " + myDiceRoll);

            Debug.Log("The percentage change of getting this number is: " + (float)(1f/6f) + "%");

            if(myDiceRoll < 3)
            {
                Debug.Log("Dice Rolls is less than 3");
            }
            else if(myDiceRoll > 3  && myDiceRoll < 5)
            {
                Debug.Log("My dice roll is greater than 3 and less than 5");
            }
            else
            {
                Debug.Log("Dice roll is 6");
            }
        }
    }
}
