using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float horizontalSpeed = 5.2f;
    public float verticalSpeed = 5.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-horizontalSpeed, 0, 0);        }
		
	}
}
