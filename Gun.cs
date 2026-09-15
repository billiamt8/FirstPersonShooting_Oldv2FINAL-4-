using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public float damage = 10f; // How much damage our gun causes

    public float range = 100f; // How far we can shoot

    public Camera fpsCam;

    private CharacterInput controls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Player.Shoot.triggered)
        {
            Shoot();
        }
    }


    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            // We can visualise the ray by this, and it can be easier for you to debug

            Debug.DrawRay(fpsCam.transform.position, fpsCam.transform.forward * hit.distance, Color.red, 1f);

            Debug.Log(hit.transform.name);

            Target enemy = hit.transform.GetComponent<Target>();



            // If the target script exists, call the function in the target script to cause damage

            if (enemy != null)
            {

                enemy.TakeDamage(damage);

            }



        }

        // else show the full length of the ray if nothing is hit 

        else { Debug.DrawRay(fpsCam.transform.position, fpsCam.transform.forward * range, Color.red, 1f); }
    }

    void Awake()

    {
        controls = new CharacterInput();
    }



    void OnEnable()

    {
        controls.Enable();
    }



    void OnDisable()

    {
        controls.Disable();
    }
}
