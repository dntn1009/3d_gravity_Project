using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float _force = 2000;
    [SerializeField] float _removalTime = 5f;

    [SerializeField] GameObject PrefabsEffect;
    public Rigidbody _rgdb3D;

    float time;
    bool Del_check;
    void Awake()
    {
        time += Time.deltaTime;
        _rgdb3D = GetComponent<Rigidbody>();
        _rgdb3D.AddForce(transform.forward * _force);
        if (time >= _removalTime)
        {
            if(!Del_check)
              Destroy(gameObject);
        }
        // Update is called once per frame
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            DestroyObj();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            Del_check = true;
            Invoke("DestroyObj", 1f);
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
        var obj = Instantiate(PrefabsEffect, transform.position, PrefabsEffect.transform.rotation);
        Destroy(obj, 1f);
    }

}
