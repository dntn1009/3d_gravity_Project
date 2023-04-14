using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObject : MonoBehaviour
{
    [SerializeField] GameObject _prefabEffectBomb;
    [SerializeField] GameObject _prefabEffectBroken;
    [SerializeField] int broke = 6;
    int demage = 0;

    /*void OnCollisionEnter(Collision collision)
    {
        *//*if(collision.transform.CompareTag("Misale"))
        {
            Destroy(collision.gameObject);
        }*//*

        if (collision.gameObject.tag == "Misale")
        {
            var obj = Instantiate(_prefabEffectBomb, collision.contacts[0].point, _prefabEffectBomb.transform.rotation);
            obj.transform.localScale *= 0.8f;
            Destroy(collision.gameObject);
            Destroy(obj, 1f);
            demage++;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Misale"))
        {
            var obj = Instantiate(_prefabEffectBomb, other.transform.position, _prefabEffectBomb.transform.rotation);
            obj.transform.localScale *= 0.8f;
            Destroy(other.gameObject);
            Destroy(obj, 1f);
            demage++;
        }
    }
    private void Update()
    {
        if (demage >= broke)
        {
            Destroy(gameObject);
            var obj = Instantiate(_prefabEffectBroken, transform.position, _prefabEffectBroken.transform.rotation);
            obj.transform.localScale *= 2f;
            Destroy(obj, 1f);
            //demage = 0;
        }
    }

}
