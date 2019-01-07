using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*                                                         Script de Movimiento
 * La script utiliza los botones WASD, para el movimiento del jugador.
 * La script movera al jugador segun la velocidad establecida en la variable VelocidadJugador en el metodo, Sistema_Banco.
 *  La funcion Awake, sirve para que ese codigo se ejecute antes que todo lo de esta script, incluso antes que void Start.
 *  transform.Translate hara que el objeto que lleve esta script sume a su cordena x,y o z  la cantidad especificada en la variable banco.VelocidadJugador.
 *  transform se refiere al componente del objeto, asi como tambien podria referirse a otro componente como RigiBody2D, AudioSource, SpriteRenderer, etc.
 */
public class ControlJugador : MonoBehaviour {

    public class PlayerControl : MonoBehaviour
    {

        void Update(){
            if (Input.GetKey(KeyCode.D)) { transform.Translate(10, 0, 0);}
                else{
                     if (Input.GetKey(KeyCode.A)){transform.Translate(-10, 0, 0); } }

            if (Input.GetKey(KeyCode.W))
                {transform.Translate(0, 0, 0);}
                else{
                     if (Input.GetKey(KeyCode.S)){transform.Translate(0, 0, 0);}}
        }
    }
}



