using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{

    public bool destruirConCursor;
    public bool destruirAutomatico;
    public MovimientosBasicos MovimientosBasicos; //Logica de personaje

    public int tipo;

    // 1 = crecer
    // 2 = aumenta velocidad
    // 3 = 

    // Start is called before the first frame update
    void Start()
    {
        //MovimientosBasicos = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientosBasicos>();
        //Logica de personaje
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //public void Efecto(){
        //switch (tipo){
            //case 1:
            //MovimientosBasicos.gameObject.transform.localScale = new Vector3(3,3,3);
            //Logica de personaje
            //break;

            //case 2:
            //MovimientosBasicos.velocidadInicial += 5;
            //break;

            //case 3:
            //MovimientosBasicos.fuerzaSalto += 10;

            //default:
            //Debug.Log("sin efecto");
            //break;
        //}
    //}


}
