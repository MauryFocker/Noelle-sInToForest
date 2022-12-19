using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ValidarUsuario : MonoBehaviour
{
    public Text CajaNombre {get;set;}
    //Interger.parseInt("8") en java
    public Text cajaEdad{get;set;}

    string nombre;
    byte edad;  //dato de edad para c sharp

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ValidarUsuario(){
        nombre = CajaNombre.text;
        edad = byte.Parse(cajaEdad.text);
        if (edad>=18){
            SceneManager.LoadScene("World");
        }
        else{
            Debug.Log($"Eri muy chico mi shangre {edad}");
        }
        SceneManager.LoadScene("Registro");
    }
}

