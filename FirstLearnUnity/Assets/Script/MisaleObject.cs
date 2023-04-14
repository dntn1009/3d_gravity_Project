using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisaleObject : MonoBehaviour
{
    [SerializeField] float _force = 100;
    [SerializeField] float _removalTime = 2f;
    Rigidbody _rgdb3D;
    float time;
    float _destroyTime;


    void Awake()
    {
        _rgdb3D = GetComponent<Rigidbody>();
        _rgdb3D.AddForce(transform.forward * _force);
        Destroy(gameObject, _removalTime);
        /*StartCoroutine(DestroyThree());*/
/*        _destroyTime = Time.time + _removalTime;*/
        //어플리케이션이 실행되는 시간과 제거할 시간을 더해서 적용

    }

    void Update()
    {
        /*time += Time.deltaTime;
        if (time > _removalTime)
            Destroy(gameObject);*/

        /*if (Time.time >= _destroyTime)
            Destroy(gameObject);*/
    }

    IEnumerator DestroyThree()
    {
        yield return new WaitForSeconds(_removalTime);
        Destroy(gameObject);
    }
}
