using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecargaEscudo : MonoBehaviour {
    public EscudoPlayer escudoplayer;
    public Banco banco;
    public float SigRegenEscudo;
    public float RegeneracionEscudo=2;

    // Use this for initialization
    void Start () {
        escudoplayer = GameObject.FindObjectOfType<EscudoPlayer>();
        banco = GameObject.FindObjectOfType<Banco>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > SigRegenEscudo)
        {
            if (banco.Escudo<3) {
                banco.Escudo++;
                SigRegenEscudo = Time.time + RegeneracionEscudo;
                escudoplayer.ActualizacionEscudo();
            }
        }

    }
}
