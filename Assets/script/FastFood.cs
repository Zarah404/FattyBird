using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFood : MonoBehaviour
{
   public float growthFactor = 1.1f;
    public float massFactor = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase player size and mass
            other.transform.localScale *= growthFactor;
            other.GetComponent<Rigidbody2D>().mass *= massFactor;

            // Destroy food object
            Destroy(gameObject);
        }
    }
}
