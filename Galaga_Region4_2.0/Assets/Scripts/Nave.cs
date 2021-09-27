using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    public GameObject bullet;
    public Transform referencia;
    public float speed = 5;
    Vector3 movement = new Vector3(0, 0, 1f);
    private CharacterController characterController;

    private IEnumerator corrutina;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Start()
    {
        corrutina = CadenciaFire();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement += new Vector3(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-speed, 0, 0);
        }
    }
   
    void Update()
    {
        movement = Vector3.zero;
        Movement();
        characterController.Move(movement * Time.deltaTime);
        Disparar();
        
    }

    void Disparar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(corrutina);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(corrutina);
        }

    }

    IEnumerator CadenciaFire()
    {
        while (true)
        {
            GameObject firedBullet = Instantiate(bullet, referencia.position, referencia.rotation);
            yield return new WaitForSeconds(0.7f);
        }
    }
}
