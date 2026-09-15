using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    [SerializeField] private float health = 50f;
    [SerializeField] private AudioClip[] damageSoundClips;

    //Prefab of the collectable

    public GameObject Collectable;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {



        // Remove the damage of the weapon from health

        health -= amount;


        SoundFXManager.instance.PlayRandomSoundFXClip(damageSoundClips, transform, 1f);


        Debug.Log(health);
        if (health <= 0f)
        {

            Die();
        }
    }
    void Die()
    {
        //We're going to Instantiate the prefab at the enemy's position before destroying the object

        Instantiate(Collectable, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
