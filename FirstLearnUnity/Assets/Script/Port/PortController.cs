using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortController : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float _rotAngle = 120f;
    //방향키 감지

    private void Awake()
    {
        //  Debug.Log(transform.rotation);
    }
    private void Update()
    {
        float ry = Input.GetAxisRaw("RotationY");
        float mz = Input.GetAxisRaw("Vertical"); // -1, 0, 1
        float mx = Input.GetAxisRaw("Horizontal");
        /*float mz = Input.GetAxis("Vertical"); // -1 ~ 1
        float mx = Input.GetAxis("Horizontal");*/

        Vector3 mv = new Vector3(mx, 0, mz);
        mv = mv.magnitude > 1 ? mv.normalized : mv;
        transform.Translate(mv * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * ry * _rotAngle * Time.deltaTime); // 2
    }


}
