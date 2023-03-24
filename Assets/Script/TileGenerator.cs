using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject[] titlePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnPos = 0;
    private float titleLength = 50;


    [SerializeField] private Transform player;
    private int starTiles = 6;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<starTiles;i++)
        {
            SpawnTile(Random.Range(0,titlePrefabs.Length));
        }
    }

    void Update()
    {
        if (player.position.z > spawnPos - (starTiles * titleLength))
            SpawnTile(Random.Range(0,titlePrefabs.Length));
    }

    private void SpawnTile(int tileIndex){
        Instantiate(titlePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        spawnPos += titleLength;
    }
}
