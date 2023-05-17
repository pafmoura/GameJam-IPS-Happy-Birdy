using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public Rigidbody projectilePrefab;
    public float maxStretchDistance = 5f;
    public float shootForce = 10f;
    private bool isPressed = false;
    private Rigidbody projectile;
    private SpringJoint springJoint;
    private float originalSpringForce;
    private Renderer projectileRenderer;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (isPressed)
        {
            Vector3 mousePosition = GetMousePosition();
            Vector3 stretchDirection = mousePosition - projectileSpawnPoint.position;
            float stretchDistance = Mathf.Clamp(stretchDirection.magnitude, 0f, maxStretchDistance);
            Vector3 stretchPosition = projectileSpawnPoint.position + stretchDirection.normalized * stretchDistance;

            projectile.position = stretchPosition;

            if (springJoint)
                springJoint.spring = originalSpringForce * (1f - stretchDistance / maxStretchDistance);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!projectile)
            {
                SpawnProjectile();
                isPressed = true;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (projectile)
            {
                isPressed = false;
                LaunchProjectile();
            }
        }
    }

    private Vector3 GetMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            return hit.point;
        }
        return Vector3.zero;
    }

    private void SpawnProjectile()
    {
        projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
        springJoint = projectile.GetComponent<SpringJoint>();
        projectileRenderer = projectile.GetComponent<Renderer>();
        projectileRenderer.enabled = false;
        originalSpringForce = springJoint.spring;
    }

    private void LaunchProjectile()
    {
        if (springJoint)
        {
            springJoint.spring = originalSpringForce;
            springJoint.connectedBody = null;
            Destroy(springJoint);
        }

        Vector3 launchDirection = projectileSpawnPoint.position - projectile.position;
        projectile.velocity = launchDirection * shootForce;

        projectileRenderer.enabled = true;
        projectile = null;
        springJoint = null;
       
    }
}
