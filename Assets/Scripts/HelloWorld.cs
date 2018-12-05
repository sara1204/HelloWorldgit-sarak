using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Console.WriteLine("Hello World"); //keine Ausgabe in Unity Console
        Debug.Log("Hello World");
        print("Hello Woorld"); //zweite funktionierende Möglichkeit
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
