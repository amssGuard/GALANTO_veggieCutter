using System.Diagnostics;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform spawnpoint;
    public bool hasSpawned = false;
    private int halvesEntered = 0;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FruitHalf"))
    {
        halvesEntered++;
        if (halvesEntered >= 2)
        {
            SpawnNewFruit();
            halvesEntered = 0;
        }
    }
    }
    
    void SpawnNewFruit()
    {
        Instantiate(fruitPrefab, spawnpoint.position, spawnpoint.rotation);
        
    }
}
