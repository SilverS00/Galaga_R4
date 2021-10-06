using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Rigidbody2D Enemigo1;

    [SerializeField] float moveSpeed = 3;

    public GameObject Bullet;

    float fireRate;
    float nextFire;
    [SerializeField] Transform objetivo;

    // Start is called before the first frame update
    void Start()
    {
        Enemigo1 = GetComponent<Rigidbody2D>();
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
            Enemigo1.velocity = new Vector2(0,-1) * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bala"))
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    void CheckIfTimetoFire()
    {
        if(Time.time > nextFire)
        {
            transform.LookAt(objetivo.position);
            Instantiate(Bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
