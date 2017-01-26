//This will change the color of ball
using UnityEngine;

public class changeColor :MonoBehaviour {
	void Update() {
		if (Input.GetKeyDown(KeyCode.D)) {
			GetComponent<Renderer>().material.color = Color.red;
			}
		if (Input.GetKeyDown(KeyCode.S)) {
			GetComponent<Renderer>().material.color = Color.green;
			}
			
		if (Input.GetKeyDown(KeyCode.A)) {
			GetComponent<Renderer>().material.color = Color.blue;
			}
        if (Input.GetKeyDown(KeyCode.W)) {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Renderer>().material.color = Color.black;
        }

    }
}