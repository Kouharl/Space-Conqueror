using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    private Banco banco;
    public GameObject AllyBullets1; //prefab de las balas tipo 1
    public GameObject AllyBullets2; //prefab de las balas tipo 2
    public Transform AllyCannonFire; // desde donde aparecera la bala
    public float SiguienteDisparo;


    void Start () {
        banco = GameObject.FindObjectOfType<Banco>();

    }
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0) && banco.AllyBulletType == 1 && Time.time > SiguienteDisparo)
        {
            Instantiate(AllyBullets1, AllyCannonFire.position, AllyCannonFire.rotation);
            Debug.Log("DISPARANDO BALAS TIPO 1");
            SiguienteDisparo = Time.time + banco.AllyBullet1TasaDisparo;
        }
       // if (Input.GetButtonDown("Fire1") && banco.AllyBulletType == 2 && Time.time > SiguienteDisparo)
            if (Input.GetKey(KeyCode.Mouse0) && banco.AllyBulletType == 2 && Time.time > SiguienteDisparo)
            {
            Instantiate(AllyBullets2, AllyCannonFire.position, AllyCannonFire.rotation);
            Debug.Log("DISPARANDO BALAS TIPO 2");
            SiguienteDisparo = Time.time + banco.AllyBullet2TasaDisparo;
        }
    }
}
