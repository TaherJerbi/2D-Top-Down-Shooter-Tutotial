using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    int wave = 5;
    public float maxSpeed = 10.0f;
    public float minSpeed = 5.0f;

    public float maxHealth = 200;
    public float minHealth = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWave", .5f, 7);

        string[] usernames = {"ada","hannibal", "tesla"};
        for(int i = 0; i < usernames.Length; i++)
        {
            Debug.Log(usernames[i]);
        }
    }

    void SpawnWave()
    {
        for(int i = 0; i < wave; i++)
        {
            Vector2 position = RandomCircle(Vector3.zero, 20);
            GameObject clone = Instantiate(zombiePrefab, position, Quaternion.identity);
            clone.GetComponent<Zombie>().speed = Random.Range(minSpeed, maxSpeed);
            clone.GetComponent<HealthManager>().health = Random.Range(minHealth, maxHealth);

            
        }
        wave++;

    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
