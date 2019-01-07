using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// BOTON DE CAMBIA QUE FUNCIONA CON SISTEMA RAYCAST. FUNCIONARA DESABILITANDO SPRITES Y HABILITANDOLOS, A SU VEZ AVISAR
// QUE OCURRIO ESE CAMBIO MEDIANTE UNA VARIABLE Y LUEGO LLAMAR UNA FUNCION EN StatsNaves, Para cambiar los stats
// A LA NAVE CORRESPONDIENTE.
public class BotonCambio : MonoBehaviour {
    private Banco banco;
    private StatsNaves Statsnaves;
    public float SiguienteCambio;
    public SpriteRenderer Nave1;
    public SpriteRenderer Nave2;
    public SpriteRenderer CNave1; //nave de cambio 1
    public SpriteRenderer CNave2; //nave de cambio 2

    private void Start()
    {
        banco = GameObject.FindObjectOfType<Banco>();
        Statsnaves = GameObject.FindObjectOfType<StatsNaves>();
    }
    void Update () {

                    //Se encarga de saber la posicion del mouse. Sin entender aun.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit) == true && hit.transform.gameObject.tag == "Cambio" && Time.time > SiguienteCambio && banco.nave1 == true) 
            {
                Debug.Log("Cambiando a Nave 2 ");
                banco.nave2 = true;
                SiguienteCambio = Time.time + banco.TiempoRecargaCambio; // Codigo para habilitar el cambio cada x Tiempo.
                banco.nave1 = false;
                            //codigo encargado de desactivar la imagen de la nave y del icono de cambio de naves.
                CNave1.GetComponent<SpriteRenderer>().enabled = true;
                Nave1.GetComponent<SpriteRenderer>().enabled = false;
                CNave2.GetComponent<SpriteRenderer>().enabled = false;
                Nave2.GetComponent<SpriteRenderer>().enabled = true;
                Statsnaves.CargarStatsNave(); // FUNCION PARA ACTUALIZAR STATS
            }
            if (Physics.Raycast(ray, out hit) == true && hit.transform.gameObject.tag == "Cambio" && Time.time > SiguienteCambio && banco.nave2 == true)
            {
                Debug.Log("Cambiando a Nave 1 ");
                banco.nave1 = true;
                SiguienteCambio = Time.time + banco.TiempoRecargaCambio; // Codigo para habilitar el cambio cada x Tiempo.
                banco.nave2 = false;
                             //codigo encargado de desactivar la imagen de la nave y del icono de cambio de naves.
                CNave2.GetComponent<SpriteRenderer>().enabled = true;
                Nave2.GetComponent<SpriteRenderer>().enabled = false;
                CNave1.GetComponent<SpriteRenderer>().enabled = false;
                Nave1.GetComponent<SpriteRenderer>().enabled = true;
                Statsnaves.CargarStatsNave(); // FUNCION QUE ACTUALIZARA LOS STATS EN PANTALLA.

            }
        }
		
	}
}
