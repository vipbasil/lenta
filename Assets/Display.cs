using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {
    private Reader reader;
	// Use this for initialization
	void Start () {
        reader = GameObject.FindObjectOfType<Reader>();
	
	}
	
	// Update is called once per frame
	void Update () {
        //this. = "" + reader.GetComponent<Reader>().register;
	}
}
