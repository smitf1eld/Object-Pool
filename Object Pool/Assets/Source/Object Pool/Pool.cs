using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Object_Pool
{
    public class Pool : MonoBehaviour
    {
        public GameObject prefab;
        public int startPoolSize;
        public int maxPoolSize;
        
        private List<GameObject> _availableObjects = new List<GameObject>();
        private int totalObjects = 0;

        private void Start()
        {
            for (int i = 0; i < startPoolSize; i++)
            {
                AddNewObjectPool();
            }
        }

        private void AddNewObjectPool()
        {
            if (totalObjects >= maxPoolSize)
            {
                GameObject obj = Instantiate(prefab);
                obj.SetActive(false);
                _availableObjects.Add(obj);
                totalObjects++;
            }
        }

        public GameObject TryGetFromPool()
        {
            if (_availableObjects.Count > 0)
            {
                GameObject obj = _availableObjects[0];
                _availableObjects.RemoveAt(0);
                obj.SetActive(true);
                return obj;
            }

            if (totalObjects < maxPoolSize)
            {
                GameObject newObj = Instantiate(prefab);
                totalObjects++;
                return newObj;
            }
            
            return null;
        }

        public void ReturnToPool(GameObject obj)
        {
            obj.SetActive(false);
            if (!_availableObjects.Contains(obj))
            {
                _availableObjects.Add(obj);
            }
        }
    }
}
