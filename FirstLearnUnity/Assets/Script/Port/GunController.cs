using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject m_bullet;
    [SerializeField] Transform m_firepos;
    [SerializeField] Transform m_Portpos;

    [SerializeField] float m_speed = 40;
    float fireTime = 1f;
    float time;

    float mz = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKey(KeyCode.F))
        {
            if ((float)transform.rotation.x <= 0.1)
            {
                transform.Translate(new Vector3(0, -1, 0) * (m_speed * Time.deltaTime) / 20);
                transform.Rotate(new Vector3(1, 0, 0) * (m_speed * Time.deltaTime));
            }
            /*if ((float)m_Portpos.transform.rotation.x <= 0.1)
            {
                mz = 1;
                Vector3 GunPos = new Vector3(mz, 0, 0);
                transform.Rotate(GunPos * (m_speed * Time.deltaTime));
            }*/
        }
        if (Input.GetKey(KeyCode.R))
        {
            if ((float)transform.rotation.x >= -0.22)
            {
                transform.Translate(new Vector3(0, 1, 0) * (m_speed * Time.deltaTime) / 20);
                transform.Rotate(new Vector3(-1, 0, 0) * (m_speed * Time.deltaTime));
            }
            /*if ((float)m_Portpos.transform.rotation.x <= -0.22)
            {
                mz = -1;
                Vector3 GunPos = new Vector3(mz, 0, 0);
                transform.Rotate(GunPos * (m_speed * Time.deltaTime));
            }*/
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (time >= fireTime)
            {

                if ((float)transform.rotation.x >= -0.03)
                    Instantiate(m_bullet, m_firepos.position, m_firepos.transform.rotation).GetComponent<BallController>()._rgdb3D.useGravity = false;
                else
                    Instantiate(m_bullet, m_firepos.position, m_firepos.transform.rotation);

                time = 0;
            }

        }
    }
}
