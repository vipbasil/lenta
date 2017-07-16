using UnityEngine;
using System.Collections;

public class Bit : MonoBehaviour {
    public int state = 0;
    public Tape tape;
    public Sprite[] sprites;

    private int HP;
	// Use this for initialization
	void Start () {
        HP = 100;
	}

	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[state];
    }
}
