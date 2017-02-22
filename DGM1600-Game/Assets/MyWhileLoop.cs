using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWhileLoop : MonoBehaviour {

    /*private int counter = 100;
    public int minCount = 0;

    private bool gameOn = true;*/

    private int randomNum;
    private int minVal = 0; // Lowest posible number
    private int maxVal = 1000; // Highest posible number
    private int count = 0;
    private int myNumber = 64;//This is were you pick a number between the min and max value

	// Use this for initialization
	void Start () {
        //With this script the computer can guess your number within 10 or less tries.
        while (true)
        {
            if (((maxVal - minVal) % 2 == 0) || /*((maxVal - 1 - minVal) % 2 == 0) ||*/ ((maxVal - minVal + 1) % 2 == 0))
            {
                randomNum = ((maxVal - minVal) / 2) + minVal;
            }
            else if ((maxVal - minVal) % 2 != 0)
            {
                randomNum = Random.Range(minVal, maxVal);
            }
            print("COMPUTER: Is the number " + randomNum + "?");
            

            if (randomNum == myNumber && count > 1)
            {
                print("YOU: Yes, you got it in " + count + " TRIES!");
                break;
            }
            else if ((randomNum == myNumber) && (count == 1))
            {
                print("YOU: WOW, you got it on the first try!");
                break;
            }

            if (randomNum > myNumber)
            {
                maxVal = randomNum - 1;
                print("YOU: No, guess lower than " + randomNum + ".");
            }
            if (randomNum < myNumber)
            {
                minVal = randomNum + 1;
                print("YOU: No, guess higher than " + randomNum + ".");
            }


            
            count++;
            if (count == 11) { print("COMPUTER: YOU CHEATED!");  break; } // If the computer has to guess more than 10 times you know you cheated.

            //Pint out the GUESS here
            // print("Attempt number " + count + ": " + minVal + " - " + maxVal + ".");
        }

      
        //Second example of the while loop
        /* while (gameOn)
        {
            print(counter + " bottles of rootbeer on the wall.");
            counter--;
            if (counter == minCount)
            {
                break;
            }
        }*/

        // Rootbeer song
		/*while(counter > minCount)
        {
            if (counter % 2 == 0)
            {
                print(counter + " bottles of rootbeer on the wall. " + counter + " bottles of rootbeer! Take two down pass them around.");
            }
            counter --;

            if (counter % 2 == 0)
            {
                print(counter + " bottles of rootbear on the wall.");
            }
        }*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
