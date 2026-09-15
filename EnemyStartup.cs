using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStartup : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // We are delaying 1.5f seconds before calling the function

        Invoke("delayAddingScript", 1.5f);
    }

    void delayAddingScript()
    {
        //Create our NavMeshAgent and then add the AI script

        gameObject.AddComponent<NavMeshAgent>();

        gameObject.AddComponent<NewEnemyAI>();

        Destroy(GetComponent<Rigidbody>());
    }

}
