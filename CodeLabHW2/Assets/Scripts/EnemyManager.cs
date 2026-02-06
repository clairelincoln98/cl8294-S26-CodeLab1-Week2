using UnityEditor;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
public GameObject enemy;

public float enemyNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (var i = 0; i < enemyNumber; i++)
        {
            Instantiate(enemy, new Vector3 (Random.Range (2, 10), Random.Range (-4, 4), 0), Quaternion.identity);
        }
        
        for (var i = 0; i < enemyNumber; i++)
        {
            Instantiate(enemy, new Vector3 (Random.Range (-10, -2), Random.Range (-4, 4), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
