using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    public float speed;

    // Use this for initialization
    void Start () {
        speed = Random.Range(0.6f, 111.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
		
	}
}
