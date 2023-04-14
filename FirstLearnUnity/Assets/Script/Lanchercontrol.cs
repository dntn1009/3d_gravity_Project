using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanchercontrol : MonoBehaviour
{
    [SerializeField] GameObject _prefabMissileObj;
    [SerializeField] Transform[] FirePos;

    public Transform LFirePos;
    public Transform RFirePos;

    float fireTime = 0.5f;
    float time;

/*    private void Awake()
    {
        LFirePos = transform.GetChild(0).GetChild(0);
        RFirePos = transform.GetChild(1).GetChild(0);
    }*/

    void Update()
    {
        time += Time.deltaTime;

            if (Input.GetButtonDown("Jump"))
            {
                if (time >= fireTime)
                {
                    time = 0;
                    Instantiate(_prefabMissileObj, FirePos[0].position, FirePos[0].transform.rotation);
                    Instantiate(_prefabMissileObj, FirePos[1].position, FirePos[1].transform.rotation);
                }
            }
    }
}
