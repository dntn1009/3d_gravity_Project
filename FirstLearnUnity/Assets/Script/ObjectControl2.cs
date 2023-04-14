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
        //if(Input.GetMouseButtonDown(0)) // 0 : �¹�ư, 1 : ���ư, 2 : ��� ��ư
        /*if(Input.GetButtonDown("Fire1")) // 1 : �¹�ư, 2 : ���ư, 3 : ��� ��ư
        {
            Debug.Log("���콺 Ŭ��");
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


        #region ���길���� �� ����
        //Vector3
        //����
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

        //�⺻���ΰ�
        /*        transform.LookAt(_goalpos);
                 transform.rotation = Quaternion.LookRotation(_goalpos - transform.position);*/

        //����
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

        //distance�� �̿��� ��� (target�� ����� transform�� ������ ���� ���� ���� ����ȭ �Ͽ� �� �������� Distance�� �̿��Ͽ� �Ÿ��� ��������� �������� ���� ���ߵ��� ����)
        //MoveToWards �� �̿��� ���(Unity���� Ÿ���� �����ǿ� ������ ���ټ� �ִ� �Լ�)

        /*Quaternion rotation = Quaternion.LookRotation(rotPos);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime);*/
        #endregion
    }

}
