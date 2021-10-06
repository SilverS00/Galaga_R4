using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float force = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * force, ForceMode2D.Impulse);
        Destroy(gameObject, 2);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }

}