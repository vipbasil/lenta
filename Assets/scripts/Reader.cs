using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Reader : MonoBehaviour {
    public Tape ActiveTape;
    public Text Display;
    private int head_position;
    public int quality;
    public char register;
	// Use this for initialization
	void Start () {
        head_position = 0;
	}
    public void read_char() {
        register =  ActiveTape.GetComponent<Tape>().get_char_at(head_position);
        head_position++;
        turn_the_display_wheel_to_char(register);


    }
    private void turn_the_display_wheel_to_char(char input) {
       //TO DO turn_the_display_wheel_to_char  input

    }
    public void Load()
    {
        //ActiveTape.transform.position = new Vector3(this.transform.position.x , this.transform.position.y + 7f /50f);
        head_position = 0;
        ActiveTape.GetComponent<Tape>().load_tape(new Vector3(this.transform.position.x + 16f / 50f, this.transform.position.y + 7f / 50f));
    }
    // Update is called once per frame
    void Update () {
        //https://en.wikipedia.org/wiki/Split-flap_display
        Display.text = "" + register;
	
	}
}
