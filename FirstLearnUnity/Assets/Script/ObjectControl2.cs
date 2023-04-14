using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl2 : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] float _rotAngle = 120f;

    Vector3 target;
    Vector3 test;

    Vector3 _goalpos;
    Vector3 rotPos;
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)) // 0 : 좌버튼, 1 : 우버튼, 2 : 가운데 버튼
        /*if(Input.GetButtonDown("Fire1")) // 1 : 좌버튼, 2 : 우버튼, 3 : 가운데 버튼
        {
            Debug.Log("마우스 클릭");
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mPos = Input.mousePosition;
            //mPos.z = Camera.main.farClipPlane;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rHit;
            int lMask = 1 << LayerMask.NameToLayer("Ground") | 1 << LayerMask.NameToLayer("Floor");
            if(Physics.Raycast(ray, out rHit, Mathf.Infinity, lMask))
            {
                _goalpos = rHit.point;
            }
        }

        Vector3 mv = _goalpos - transform.position;
        Quaternion rotation = Quaternion.LookRotation(mv);
        if (mv.magnitude <= 0.1f)
        {
            transform.position = _goalpos;
        }
        else
        {
            rotation = Quaternion.LookRotation(_goalpos - transform.position);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, _rotAngle * Time.deltaTime);


        #region 연산만으로 한 정답
        //Vector3
        //정답
        /*Vector3 mv = _goalpos - transform.position;

        if(mv.magnitude <= 0.1f)
        {
            transform.position = _goalpos;
        }
        else
        {
            transform.position += mv.normalized * speed * Time.deltaTime;
        }*/

        //transform.position = Vector3.MoveTowards(transform.position, _goalpos, Time.deltaTime * speed);
        //transform.position = Vector3.Lerp(transform.position, _goalpos, Time.deltaTime * speed);

        //Quternion

        //기본적인것
        /*        transform.LookAt(_goalpos);
                 transform.rotation = Quaternion.LookRotation(_goalpos - transform.position);*/

        //정답
        /* Quaternion rotation = Quaternion.LookRotation(mv);
           transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime);*/

        #endregion

        #region myCoding

        /* if (Input.GetMouseButtonDown(0))
         {
             Vector3 mPos = Input.mousePosition;
             //mPos.z = Camera.main.farClipPlane;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

             RaycastHit rHit;
             if (Physics.Raycast(ray, out rHit))
             {
                 target = rHit.point;
                 test = (rHit.point - transform.position).normalized;
             }
         }
         if (Vector3.Distance(transform.position, target) > 0.25f)
             transform.position += test * (speed * Time.deltaTime);*/

        //transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        //transform.rotation = Quaternion.LookRotation(test);

        //distance를 이용한 방식 (target의 방향과 transform의 방향을 빼서 나온 값을 정규화 하여 그 방향으로 Distance를 이용하여 거리가 가까워지면 오차범위 내에 멈추도록 설정)
        //MoveToWards 를 이용한 방식(Unity에서 타겟의 포지션에 가도록 해줄수 있는 함수)

        /*Quaternion rotation = Quaternion.LookRotation(rotPos);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime);*/
        #endregion
    }

}
