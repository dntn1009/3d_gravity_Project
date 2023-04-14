using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    const float _gravity = -9.81f;
    [SerializeField] float _gravityScal = 1;
    Vector3 _originGravity;

    void Awake()
    {
        _originGravity = Physics.gravity;
    }

    void Update()
    {
        float gh = Input.GetAxis("Horizontal");
        float gv = Input.GetAxis("Vertical");

        //Input.acceleration

        Vector3 gVec = new Vector3(gh, 1, gv);
        Physics.gravity = (_originGravity + gVec) * _gravityScal;
    }
}
