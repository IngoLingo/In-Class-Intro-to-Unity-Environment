using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CountToTen();
        CountToTen();
        CountToTen();
        CountToTen();
    }
	
	
	void CountToTen () {
        int i = 1;
        while(i <=10 )
        {
            print(i);
            i++;
        }
        print("Good JOB!");
	}
}
