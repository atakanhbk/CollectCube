using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    /*
    void OnCollisionEnter(Collision collision)
    {
        // temas edilen objenin Rigidbody bile�enine eri�mek i�in GetComponent kullan�n
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        // e�er temas edilen objede Rigidbody varsa, itme kuvveti uygulay�n
        if (rb != null)
        {
            // temas edilen objenin normal vekt�r�ne g�re itme kuvveti hesaplay�n
            Vector3 forceDirection = -collision.contacts[0].normal;
            float forceMagnitude = 10f; // itme kuvvetinin b�y�kl���
            Vector3 force = forceDirection * forceMagnitude;

            // itme kuvvetini uygulay�n
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
    */
}
