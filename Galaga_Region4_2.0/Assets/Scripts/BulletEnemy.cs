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
        //rb2d.AddForce(transform.down * force, ForceMode2D.Impulse);
        Destroy(gameObject, 2);
    }
  void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.CompareTag("Player"))
        {
            Destroy(c.gameObject);
        }
    }
}
