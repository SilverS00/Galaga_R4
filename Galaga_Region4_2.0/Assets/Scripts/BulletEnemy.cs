using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float force = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
