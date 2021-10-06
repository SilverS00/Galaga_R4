using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
