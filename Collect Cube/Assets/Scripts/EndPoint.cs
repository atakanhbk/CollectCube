using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public float pullRadius = 10f; // Çekim alaný yarýçapý
    public float pullForce = 10f; // Çekme kuvveti

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Vector3 direction = transform.position - other.transform.position;
            direction.y = 0.5f; // Y ekseni çekmeyi engelle
            float distance = direction.magnitude;

            if (distance < pullRadius)
            {
                direction.Normalize();
                float strength = (1f - distance / pullRadius) * pullForce;
                other.transform.Translate(direction * strength * Time.deltaTime, Space.World);
            }
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            
            StartCoroutine(SetDisableCubesComponents(other.gameObject));
        }
    }

    IEnumerator SetDisableCubesComponents(GameObject otherObject)
    {
        yield return new WaitForSeconds(1);
        otherObject.gameObject.tag = "Untagged";
    }
}
