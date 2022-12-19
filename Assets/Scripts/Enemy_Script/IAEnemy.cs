using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{

    public Transform Objetivo;
    public float VelocidadEnemy = 3.0f;
    private Animator anim;
    public NavMeshAgent IA;
    public float x, y;

    public float velocidadMovimiento_Enemy = 15.0f;
    public float velocidadRotacion_Enemy = 200.0f;

    //public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        IA.speed = VelocidadEnemy;
        IA.SetDestination(Objetivo.position);

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion_Enemy, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento_Enemy);

        anim.SetFloat("VelX_Enemy", x);
        anim.SetFloat("VelY_Enemy", y);

    }
}
