using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIfStatement : MonoBehaviour {
    private int maxTime = 240;
    private string fstPlayerName = "LINK";
    private string sndPlayerName = "INGO";
    private bool fstAwake = false;
    private bool sndAwake = false;
    private float time = 0f;
    private int days = 0;
	
	// Update is called once per frame
	void Update () {

        if (days == 7) // This makes the script not continue.
        {
            print("This assignment is now over!");
            time = 0f;
        }

        if (time >= maxTime)
        {// Reset the clock once you hit the max time
            print("It is now midnight...");
            time = 0f;
            days++;
            print("Day: " + days);
        }


        if (time == 50)
        {// This is letting us know that player 1 is awake.
            print(fstPlayerName + " is now awake!");
            fstAwake = true;
        }
        if (time == 70)
        {// This is letting us know that player 2 is awake.
            print(sndPlayerName + " is now awake!");
            sndAwake = true;
        }

        if (time == 100)
        {// This is letting us know that player 1 is having breakfast.
            print(fstPlayerName + " is having breakfast.");
        }
        if (time == 120)
        {// This is letting us know that player 2 went to school.
            print(sndPlayerName + " went to school.");
        }


        if (time == 170)
        {// This is letting us know that player 1 is having dinner.
            print(fstPlayerName + " is having dinner.");
        }
        if (time == 180)
        {// This is letting us know that player 2 came home from school.
            print(sndPlayerName + " came home from school.");
        }


        if (time == 200)
        {// This is letting us know that player 1 is asleep.
            print(fstPlayerName + " is now asleep!");
            fstAwake = false;
        }
        if (time == 230)
        {// This is letting us know that player 2 is asleep.
            print(sndPlayerName + " is now asleep!");
            sndAwake = false;
        }

        // Increases the time by 1 and prints it out
        time += 1f;
    }
}
