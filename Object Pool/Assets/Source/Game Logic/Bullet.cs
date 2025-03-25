using Source.Object_Pool;
using UnityEngine;

namespace Source.Game_Logic
{
    public class Bullet : MonoBehaviour
    {
        public float lifetime = 5f;

        void OnEnable()
        {
            Invoke("DisableBullet", lifetime);
        }

        void DisableBullet()
        {
            FindObjectOfType<Pool>().ReturnToPool(gameObject);
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            FindObjectOfType<Pool>().ReturnToPool(gameObject);
        }
    }
}