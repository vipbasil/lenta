using UnityEngine;
using System.Collections;

public class Reader : MonoBehaviour {
    public Tape ActiveTape;
    private int head_position;
    public char register;
	// Use this for initialization
	void Start () {
        head_position = 0;
	}
    public void read_char() {
        register =  ActiveTape.GetComponent<Tape>().get_char_at(head_position);
        head_position++;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
