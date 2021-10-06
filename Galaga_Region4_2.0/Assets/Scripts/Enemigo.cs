using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] Transform objetivo;
    [SerializeField] Rigidbody2D Enemigo1;

    [SerializeField] float moveSpeed = 3;

    public GameObject Bullet;
    private bool isShooting;

    void ShootAtPlayer()
    {
        if (isShooting) return;
        StartCoroutine(Disparo());
    }
    void Update()
    {
        moveEnemigo1();
        ShootAtPlayer();
        Vector2 direction = (objetivo.position - transform.position);
        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    public void moveEnemigo1()
    {
            Enemigo1.velocity = new Vector2(-1,0) * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bala"))
        {
            Destroy(gameObject);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Disparo()
    {
        if (isShooting) yield break;
        isShooting = true;
        Vector2 direction = (objetivo.position - transform.position);
        GameObject c = Instantiate(Bullet, transform.position, Quaternion.identity);
        c.GetComponent<BulletEnemy>().Shoot(direction);
       yield return new WaitForSeconds(2);
        isShooting = false;
    }
            
      
}
