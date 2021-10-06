using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public float hitPoints = 5;
    float currentHitPoints;


    void Start()
    {
        currentHitPoints = hitPoints;
    }

    void TakeDamage(int damage)
    {
        currentHitPoints -= damage;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletEnemigo")
        {
            TakeDamage(1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (currentHitPoints <= 0)
        {
            Restart();
        }
    }
}
