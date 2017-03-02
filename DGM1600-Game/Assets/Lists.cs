using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

    public string animal;
    public List<string> zooRoster = new List<string>();

	// Use this for initialization
	void Start () {
        zooRoster.Add("monkey");
        zooRoster.Add("elephant");
        zooRoster.Add("alligator");
    }

    // 
    public void AddAnimal() {
        if (animal != "")
        {
            zooRoster.Add(animal);
        }
		
	}
    public void RemoveAnimal()
    {
        if (animal != "")
        {
            if (zooRoster.Contains(animal) == true)
            {
                zooRoster.Remove(animal);
            }
        }

    }
    public void ClearZoo()
    {
        if (zooRoster.Count != 0)
        {
            zooRoster.Clear();
        }

    }
    public void PrintZoo()
    {
        int i = 0;
        while (i < zooRoster.Count)
        {
            print(zooRoster[i]);
            i++;
        }

    }
}
