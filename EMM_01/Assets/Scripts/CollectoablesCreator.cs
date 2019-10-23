using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectoablesCreator : MonoBehaviour
{

    public Transform myPrefab;
    public int numberOfCollectables = 20;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfCollectables; i++) { 
         Transform myObject = Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(-9f, 9f), 1, UnityEngine.Random.Range(-9f, 9f)), Quaternion.identity);
         myObject.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
