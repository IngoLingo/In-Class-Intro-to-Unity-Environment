using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySwitch : MonoBehaviour {

    //Movement string
    private string myDirection;
    //For the movement switch
    public float horizontalSpeed = 5.2f;
    public float verticalSpeed = 5.2f;

    //For the time switch
    private int time = 15;

    //For the animal switch
    private string animal = "Bird";
    private string phrase;
    private bool exists = true;

    //Number switch
    private int i = 1;

    //Final Switch example
    private bool theEnd = true;

    // Use this for initialization
    void Start () {
   
        switch (time)//Switch statement about time.
        {   case 9:
                print("Good morning?");
                break;
            case 12:
                print("Lunch Time?");
                break;
            case 18:
                print("Go home?");
                break;
            default:
                print("Get back to work?");
                break;
        }



        switch (animal) //Simple switch statement about animal noises.
        {
            case "Bird":
                phrase = "Tweet";
                break;
            case "Fish":
                phrase = "Blub";
                break;
            case "Cat":
                phrase = "Meow";
                break;
            default:
                exists = false;
                break;
        }
        // This is the moment where we print out the results.
        if (exists == true)
        {
            print("The " + animal + " says \"" + phrase + ".\"");// Prints out the animal you typed and sates that sound it makes
        }  
        else print(animal + " dose not exist."); // This prints out the word you typed and states that it is not an animal.

        switch (i)
            {
            case 1:
            print("One!");
            break;
            case 2:
                print("One");
                print("Two");
            break;
            default:
                print("Other");
            break;
        }
        switch (theEnd)
        {
            case true:
                print("YES, I am finaly done!");
                break;
            case false:
                print("NO, I am not done!");
                break;
            default:
                print("I don't Know?");
                break;
        }
    }

    void Update()
    {
        switch (myDirection)
        {
            case "Up":
                {
                    //Player moves up
                    gameObject.transform.Translate(0, verticalSpeed, 0);
                    break;
                }
            case "Down":
                {
                    //Player moves down
                    gameObject.transform.Translate(0, -verticalSpeed, 0);
                    break;
                }
            case "Left":
                {
                    //Player moves left
                    gameObject.transform.Translate(-horizontalSpeed, 0, 0);
                    break;
                }
            case "Right":
                {
                    //Player moves right
                    gameObject.transform.Translate(horizontalSpeed, 0, 0);
                    break;
                }
            default:
                print("I am not moving");
                break;
        }
        
    }

    }
