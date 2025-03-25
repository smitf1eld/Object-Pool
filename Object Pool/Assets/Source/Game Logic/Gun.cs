using System;
using Source.Object_Pool;
using UnityEngine;

namespace Source.Game_Logic
{
    public class Gun : MonoBehaviour
    {
        public Pool bulletpool;
        public Transform firePoint;
        public float speed = 50f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            GameObject bullet = bulletpool.TryGetFromPool();
            if (bullet != null)
            {
                bullet.transform.position = firePoint.position;
                bullet.transform.rotation = firePoint.rotation;
                
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.forward * speed);
            }
        }
    }
}
