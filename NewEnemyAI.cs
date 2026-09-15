using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewEnemyAI : MonoBehaviour
{
    Transform Player;

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        // Find our NavMeshAgent component and adjust some parameters, check below for more

        // https://docs.unity3d.com/ScriptReference/AI.NavMeshAgent.html

        agent = GetComponent<NavMeshAgent>();

        agent.speed = 3f;

        agent.stoppingDistance = 2.5f;

    }
}
