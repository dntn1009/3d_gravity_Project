using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl1 : MonoBehaviour
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
        /*float ry = 0;
        float mz = 0;
        float mx = 0;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            mz += 1;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            mz -= 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            mx -= 1;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mx += 1;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            ry -= 1;
        }
        if(Input.GetKey(KeyCode.E))
        {
            ry += 1;
        }*/


        /*    Vector3 mv = transform.rotation * new Vector3(mx, 0, mz);
            mv = mv.magnitude > 1 ? mv.normalized : mv;
            transform.position += mv * (speed * Time.deltaTime);
            transform.rotation = transform.rotation * Quaternion.Euler(0, ry * _rotAngle * Time.deltaTime, 0);*/ //1

        float ry = Input.GetAxisRaw("RotationY");
        float mz = Input.GetAxisRaw("Vertical"); // -1, 0, 1
        float mx = Input.GetAxisRaw("Horizontal");
        /*float mz = Input.GetAxis("Vertical"); // -1 ~ 1
        float mx = Input.GetAxis("Horizontal");*/

        Vector3 mv = transform.rotation * new Vector3(mx, 0, mz);
        mv = mv.magnitude > 1 ? mv.normalized : mv;
        transform.Translate(mv * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * ry * _rotAngle * Time.deltaTime); // 2

        #region mycoding


        /*float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal < 0)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        else if (horizontal > 0)
            transform.rotation = Quaternion.Euler(0f, 0, 0f);

        if (vertical < 0)
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        else
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);

        Vector3 mv = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        transform.position +=  mv;*/

        /*if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
           Vector3 test =  new Vector3(1, 0, 0);

            transform.position += test * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 test = new Vector3(-1, 0, 0);

            transform.position += test * speed * Time.deltaTime;
        }*/
        #endregion

    }

}
