using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }

    IEnumerator Enemyspawn()
    {
        while (true)
        {
            Vector3 enemyspawn = new Vector3(-1, 1.5f, 0);
            Instantiate(enemy, enemyspawn, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
