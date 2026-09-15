using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawn : MonoBehaviour
{
    public int numEnemies = 100;

    public GameObject prefab; // Drag the Enemy prefab here

    public Transform playerTransform; // Drag your Player object here

    public float spawnRadius = 20f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)

        {

            makeAChild();

        }
    }
    // Update is called once per frame
    void Update()
    {
        // Get the current number of enemies

        int currentChildren = transform.childCount;


        // if there are less enemies than there were originally, make another

        if (transform.childCount < numEnemies)

        {

            makeAChild();

        }
    }
    void makeAChild()
    {
        Vector3 centerPosition = playerTransform != null ? playerTransform.position : Vector3.zero; // if the player transform is not null, set the centre spawn position   to player position

        float childX = centerPosition.x + Random.Range(-spawnRadius, spawnRadius);

        float childZ = centerPosition.z + Random.Range(-spawnRadius, spawnRadius);

        Vector3 spawnPosition = new Vector3(childX, 10f, childZ);



        GameObject newChild = Instantiate(prefab, spawnPosition, Quaternion.identity);

        newChild.transform.SetParent(transform); // Parents enemy to the GameManager, not the Player/Enemy


    }
}

