using UnityEngine;
using System.Collections;

public class Byte : MonoBehaviour {
    private Bit[] bits = new Bit[8];
    public Tape tape;
    public byte byte_value = 0;
    public char char_value = (char)0;
    public char set_new_char_value = (char)0;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 8; i++)
        {
            bits[i] = Instantiate(Resources.Load("Bit", typeof(Bit)), new Vector3(gameObject.transform.position.x , gameObject.transform.position.y + 7f / 50f + i * 10f/ 50f, gameObject.transform.position.z -1), Quaternion.identity) as Bit;
            bits[i].state = Random.Range(0,2);
            bits[i].transform.parent = gameObject.transform;
            bits[i].tape = this.tape;
            byte_value += (byte)(bits[i].state * Mathf.Pow(2,i));
        }
        char_value = (char)byte_value; 
    }
    
	//TO DO - add damage to bytes and change bits value;
	// Update is called once per frame
	void Update () {
        /*byte_value = 0;
        for (int i = 0; i < 8; i++)
        {
           byte_value += (byte)(bits[i].state * Mathf.Pow(2, i));
        }
        char_value = (char)byte_value;*/
        if (set_new_char_value != char_value)
        {
            set_char_value(set_new_char_value);
        }

    }
    public void set_char_value(char char_value) {
        set_byte_value((byte) char_value);
        this.char_value = char_value;
    }
    public char get_char_value()
    {
        return char_value;
    }

    public void set_byte_value(byte byte_value) {
        this.byte_value = byte_value;
        for (int i = 0; i < 8; i++) {
            bits[i].state = ((byte_value & (1 << i)) >> i);
        }

    }
    public byte get_byte_value()
    {
        return byte_value;
    }
}
