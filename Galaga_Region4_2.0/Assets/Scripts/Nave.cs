using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{


    public float speed = 5;
    Vector3 movement = new Vector3(0, 0, 1f);
    private CharacterController characterController;


    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {

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
    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        Movement();
        characterController.Move(movement * Time.deltaTime);





        //transform.position += Vector3.right;
    }
}
