using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyFood : MonoBehaviour
{
    public float shrinkFactor = 0.99f;
    public float massFactor = 0.5f;

    //[SerializeField] private AudioSource eatHealthySoundEffect ;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //eatHealthySoundEffect.Play();

            // Decrease player size and mass
            other.transform.localScale *= shrinkFactor;
            other.GetComponent<Rigidbody2D>().mass *= massFactor;

            // Destroy food object
            Destroy(gameObject);
        }
    }
}
