using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groovebar : MonoBehaviour {
    private float time = 0;
	public float beatlength; //left undefined so you can define it per song in the editor
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0, (float)-(this.beatlength*24*Time.deltaTime), 0); //.4456 is the length of a beat or something in the bpm of the song?
        time += Time.deltaTime;
	}
}
