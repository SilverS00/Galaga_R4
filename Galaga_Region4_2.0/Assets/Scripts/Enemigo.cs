using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Rigidbody2D Enemigo1;

    public float moveSpeed = 3;

    public bool changeDirection = false;

    public GameObject Bullet;

    float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        Enemigo1 = this.gameObject.GetComponent<Rigidbody2D>();
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemigo1 ();
        CheckIfTimetoFire();
    }

    public void moveEnemigo1()
    {
        if (changeDirection == true)
        {
            Enemigo1.velocity = new Vector2(1,0) * -1 * moveSpeed;
        }

        else if (changeDirection == false) 
        {
            Enemigo1.velocity = new Vector2 (1,0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "LeftWall")
        {
            changeDirection = false;
        }

        if (col.gameObject.name == "RightWall")
        {
            changeDirection = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bala"))
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }

    void CheckIfTimetoFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}