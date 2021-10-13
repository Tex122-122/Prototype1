using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public float minXPos;
    public float maxXPos;
    public float minZPos;
    public float maxZPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 30)
        {
            float xPos = Random.Range(minXPos, maxXPos);
            float zPos = Random.Range(minZPos, maxZPos);
            Instantiate(theEnemy, new Vector3(xPos, -0.015f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;

        }
    }
}