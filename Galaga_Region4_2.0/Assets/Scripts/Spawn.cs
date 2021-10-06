using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] referenceSpawn;
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
            for (int i = 0; i < 3; i++)
            {
                GameObject c = Instantiate(enemy, referenceSpawn[i].position, Quaternion.identity);
                c.SetActive(true);
            }
            
            yield return new WaitForSeconds(3);
        }
    }
}
