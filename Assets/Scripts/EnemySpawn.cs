using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnPoint;
    public GameObject[] enemies;
    public float second;
    public Health playerscript;
    bool first = true;

    private void Update()
    {
        StartCoroutine(Spawn());
            first = false;//to prevent Update from running Spawn function multiple times
        
    }

    public IEnumerator Spawn()
    {
        enemies = new GameObject[1];

        while(!playerscript.isdead && playerscript.isGameStarted){//5 enemies spawn in the range of the platform after game starts 
            for(int i = 0; i < enemies.Length; i++)
            {
                GameObject clone = (GameObject)Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(second);
        }
    }
}
