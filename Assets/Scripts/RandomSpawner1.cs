using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner1 : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, -0.7f),3.9f, Random.Range(-3, 28));
        Instantiate(playerPrefab, randomSpawnPosition, Quaternion.identity);
        Vector3 rotation = new Vector3(0, 180f, 0);
        GameObject.Find("Low Poly Car 1(Clone)").transform.Rotate(rotation);
    }
}
