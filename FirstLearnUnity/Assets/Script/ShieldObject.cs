using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldObject : MonoBehaviour
{
    [SerializeField] GameObject PrefabDestroyEffect;
    [SerializeField] GameObject PrefabPassEffect;

    [SerializeField] int DestroyPer = 55;

    int random;

    private void OnTriggerEnter(Collider other)
    {
        random = Random.Range(0, 100);

        if (other.CompareTag("Misale") && random <= DestroyPer)
        {
            var obj = Instantiate(PrefabDestroyEffect, other.transform.position, PrefabDestroyEffect.transform.rotation);
            Destroy(other.gameObject);
            Destroy(obj, 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Misale"))
        {
            var obj = Instantiate(PrefabPassEffect, other.transform.position, PrefabPassEffect.transform.rotation);
            Destroy(obj, 1f);
            Debug.Log(random);
        }
    }
}
