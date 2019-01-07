using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioBlackHole : MonoBehaviour {
    private Banco EnInicioBlackHole;
	void Start () {
        EnInicioBlackHole = GameObject.FindObjectOfType<Banco>();
    }
    
     void OnTriggerEnter2D(Collider2D fasdfas)
    {
        //if (collision.CompareTag ("Jugador")) {
        Debug.Log("Hola");
        EnInicioBlackHole.InicioBlackHole = true;
        EnInicioBlackHole.ExperienciaH1++;
        SceneManager.LoadScene("Escena 1");

    }
    }

