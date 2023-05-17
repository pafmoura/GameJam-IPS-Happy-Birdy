using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Rigidbody bulletPrefab;
    public float maxStretchDistance = 5f;
    public float shootForce = 10f;
    private bool isPressed = false;
    private Rigidbody bullet;
    private SpringJoint springJoint;
    private float springForce;
    private Renderer bulletRenderer;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (isPressed)
        {
            Vector3 mousePosition = GetMousePosition();
            Vector3 stretchDirection = mousePosition - bulletSpawnPoint.position;
            float stretchDistance = Mathf.Clamp(stretchDirection.magnitude, 0f, maxStretchDistance);
            Vector3 stretchPosition = bulletSpawnPoint.position + stretchDirection.normalized * stretchDistance;

            bullet.position = stretchPosition;

            if (springJoint)
                springJoint.spring = springForce * (1f - stretchDistance / maxStretchDistance);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (!bullet)
                {
                    SpawnProjectile();
                    isPressed = true;
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                if (bullet)
                {
                    isPressed = false;
                    LaunchProjectile();
                }
            }
        }
    }

    private Vector3 GetMousePosition()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                return hit.point;
            }
        }
        return Vector3.zero;
    }

    private void SpawnProjectile()
    {
        bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        springJoint = bullet.GetComponent<SpringJoint>();
        bulletRenderer = bullet.GetComponent<Renderer>();
        bulletRenderer.enabled = false;
        springForce = springJoint.spring;
    }

    private void LaunchProjectile()
    {
        if (springJoint)
        {
            springJoint.spring = springForce;
            springJoint.connectedBody = null;
            Destroy(springJoint);
        }

        Vector3 launchDirection = bulletSpawnPoint.position - bullet.position;
        bullet.velocity = launchDirection * shootForce;

        bulletRenderer.enabled = true;
        bullet = null;
        springJoint = null;
       
    }
}
