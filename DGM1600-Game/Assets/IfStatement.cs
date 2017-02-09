using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {
    private int A = 10;
    private int B = 10;
    private string fstPlayerName = "Link";
    private string sndPlayerName = "Ingo";
    private bool awake = false;
    private float time = 0.0f;


    // Use this for initialization
    void Start () {
        if (A == B)
        {
            print("A is equal to B");
        }
        if (A != B)
        {
            print("A is not equal to B");
        }
        if (A > B)
        {
            print("A is greater then B");
        }
        if (A < B)
        {
            print("A is less than B");
        }
        if (A >= B)
        {
            print("A is greater than or equal to B");
        }
        if (A <= B)
        {
            print("A is less than or equal to B");
        }
    }
}
