using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{
    private string[] verb = { "eating", "playing with", "murduring", "jumping into", "running with", "running away from", "learning from" };
    private string[] kid = { "Annie", "Timmy", "Sue", "Bob", "Betty", "Nedd", "Mell", "Jim" };
    private string[] discription = { "favorit", "least favorit", "mediocre" };
    private string[] item = { "toy", "game", "cereal", "food", "pile of food", "super villen", "ghost" };
    private string[] itemName1 = { "Blaster", "Master", "Radioactive", "Wonder", "Mad", "Super", "Mega", "Demon", "Cool", "THE" };
    private string[] itemName2 = { "Masters", "Blasters", "Bacon", "Demons", "Gas" };
    private string[] verb2 = { "eat", "shoot", "fling", "fire", "toss", "stream" };
    private string[] color1 = { "red", "blue", "green", "purple", "yellow", "pink", "brown", "orange", "black", "grey", "white" };
    private string[] items = { "lazers", "polkadots", "balls", "nuggets", "boxes", "pyramids", "pillers" };
    private string[] bodyPart = { "mouth", "butt", "hands", "fist", "eyes", "hair", "leg", "feet", "arms", "belly button" };
    private string[] heroName = { "Wonder", "Mad", "Super", "Mega", "Demon", "Cool", "Master", "The" };
    private string[] bodyPartCap = { "Mouth", "Butt", "Hand", "Fist", "Eyes", "Hair", "Legs", "Foot", "Arm", "Belly Button" };
    private int bodyPartNum;
    private int heroNameNum;
    private int kidName;
    private int verbNum;
    private string herHis;
    private string herHim;
    private string sheHe;
    //private int ;//add random string of numbers'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    // Use this for initialization
    void Start()
    {
        bodyPartNum = Random.RandomRange(0, bodyPart.Length);
        heroNameNum = Random.RandomRange(0, heroName.Length);
        heroNameNum = Random.RandomRange(0, heroName.Length);
        verbNum = Random.RandomRange(0, verb2.Length);
        if (kidName % 2 == 0)
        {
            herHis = "her"; sheHe = "she"; herHim = "her";
        }
        else { herHis = "his"; herHim = "him"; sheHe = "he"; }


        print(kid[kidName] + " was " + verb[Random.RandomRange(0, verb.Length)] + " " + herHis + " " + discription[Random.RandomRange(0, discription.Length)] + " " + item[Random.RandomRange(0, item.Length)] + ", " + itemName1[Random.RandomRange(0, itemName1.Length)] + " " + itemName2[Random.RandomRange(0, itemName2.Length)] + ". ");
        print("It sudanly gave " + herHim + " the power to " + verb2[verbNum] + " " + color1[Random.RandomRange(0, color1.Length)] + " " + items[Random.RandomRange(0, items.Length)] + " with " + herHis + " " + bodyPart[bodyPartNum] + "! " + kid[kidName] + " became the super hero known as " + heroName[heroNameNum] + " " + bodyPartCap[bodyPartNum] + "!");
        print(heroName[heroNameNum] + " " + bodyPartCap[bodyPartNum] + " would fight crime by aming " + herHis + " " + bodyPart[bodyPartNum] + " at the foe, and " + verb2[verbNum] + ".");

    }

    // Update is called once per frame
    void Update()
    {
        //press R to restart	
    }
}