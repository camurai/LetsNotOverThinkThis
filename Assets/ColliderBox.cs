using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("asdf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        // Destroy(gameObject);
        print("HIT");

    }
}
