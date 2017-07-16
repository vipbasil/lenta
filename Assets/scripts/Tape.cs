using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tape : MonoBehaviour {
    
    public char[] Chars;
    public int Quality;
    public int Durability;
    // Use this for initialization

    private List<Byte> Bytes = new List<Byte>();
    void Start () {
        for (int i = 0; i < Chars.Length; i++) {
            Bytes.Add(Instantiate(Resources.Load("Byte", typeof(Byte)), new Vector3(gameObject.transform.position.x  + i * 16f / 50f, gameObject.transform.position.y , gameObject.transform.position.z - 1), Quaternion.identity) as Byte);
            Bytes[i].transform.parent = gameObject.transform;
            Bytes[i].set_new_char_value = Chars[i];
            Bytes[i].tape = this;

        }

	
	}
    public int get_tape_length() {
        return this.Chars.Length;
    }

    public char get_char_at(int position) {
        return Bytes[position].GetComponent<Byte>().get_char_value();
    }
    // Update is called once per frame
    void Update () {
	
	}
}
