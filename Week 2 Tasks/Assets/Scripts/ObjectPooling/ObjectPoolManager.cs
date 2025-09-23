using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class ObjectPoolManager : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPool
    {
        public string tag;                                          // Tag to identify the pool
        public GameObject prefab;                               // Prefab to be pooled
        public int size;                                             // Initial size of the pool
    }
    public List<ObjectPool> pools;                                    // List of different pools
    Dictionary<string, Queue<GameObject>> poolDictionary;              // Dictionary to hold the pools

    public static ObjectPoolManager Instance;                       // Singleton instance

    private void Awake()
    { 
        if(Instance == null)
        {
            Instance = this;                                       // Set the instance if it's null
            DontDestroyOnLoad(gameObject);                        // Make the instance persistent across scenes
        }
        else
        {
            Destroy(gameObject);                                   // Destroy the duplicate instance
        }
    }


    // first frame of the game 
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();       // Initialize the dictionary


        // Loop through each pool and create the objects
        foreach(ObjectPool pool in pools)
        {
            Queue<GameObject> objects = new Queue<GameObject>();      // Create a new queue for each pool

            // Instantiate the objects and add them to the queue
            for (int i =0;i<pool.size;i++)
            {
                GameObject obj = Instantiate(pool.prefab);          // Instantiate the prefab
                obj.SetActive(false);                               // Deactivate the object
                objects.Enqueue(obj);                               // Add the object to the queue
            }

            poolDictionary.Add(pool.tag, objects);          // Add the queue to the dictionary with the tag as key
        }
    }

    public GameObject SpawnFromPool(string tag,Vector3 position, Quaternion rotation)
    {
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();      // Get the object from the pool

        objectToSpawn.SetActive(true);                                 // Activate the object
        objectToSpawn.transform.position = position;                  // Set the position
        objectToSpawn.transform.rotation = rotation;                  // Set the rotation

        poolDictionary[tag].Enqueue(objectToSpawn);                  // Add the object back to the pool
        return objectToSpawn;
    }
}
