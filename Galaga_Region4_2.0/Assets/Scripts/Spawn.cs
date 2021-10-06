using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform referenceSpawn;
    [SerializeField] Transform referenceSpawn2;
    [SerializeField] Transform referenceSpawn3;
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
            Instantiate(enemy, referenceSpawn.position, Quaternion.identity);
            Instantiate(enemy, referenceSpawn2.position, Quaternion.identity);
            Instantiate(enemy, referenceSpawn3.position, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
