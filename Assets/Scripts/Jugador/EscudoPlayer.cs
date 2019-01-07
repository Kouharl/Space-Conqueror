using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoPlayer : MonoBehaviour {
    private Banco banco;
    public SpriteRenderer Vida1;
    public SpriteRenderer Vida2;
    public SpriteRenderer Vida3;
    public SpriteRenderer Vida4;
    public SpriteRenderer Vida5;
    public SpriteRenderer Vida6;
    public SpriteRenderer Vida7;
    public SpriteRenderer Vida8;
    public SpriteRenderer Vida9;
    public SpriteRenderer Vida10;


    // Use this for initialization
    void Start () {
        banco = GameObject.FindObjectOfType<Banco>();

    }
	
	// Update is called once per frame
	public void ActualizacionEscudo () {
        if (banco.Escudo < 10) { Vida10.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 9) { Vida9.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 8) { Vida8.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 7) { Vida7.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 6) { Vida6.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 5) { Vida5.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 4) { Vida4.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 3) { Vida3.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 2) { Vida2.GetComponent<SpriteRenderer>().enabled = false; }
        if (banco.Escudo < 1) { Vida1.GetComponent<SpriteRenderer>().enabled = false; }

        if (banco.Escudo > 0) { Vida1.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 1) { Vida2.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 2) { Vida3.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 3) { Vida4.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 4) { Vida5.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 5) { Vida6.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 6) { Vida7.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 7) { Vida8.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 8) { Vida9.GetComponent<SpriteRenderer>().enabled = true; }
        if (banco.Escudo > 9) { Vida10.GetComponent<SpriteRenderer>().enabled = true; }

                                            
    }
}
