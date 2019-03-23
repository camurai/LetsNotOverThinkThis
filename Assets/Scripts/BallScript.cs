using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    private bool hitComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("OncePerSecond", 1, 1);
    }

    void OncePerSecond()
    {
        transform.Translate(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {

        if (this.hitComplete) {
            return;
        }
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * 5);

        // // Move the object upward in world space 1 unit/second.
        // transform.Translate(Vector3.up * Time.deltaTime, Space.World);

        // // Move the object upward in world space 1 unit/second.
        // transform.Rotate(2, 0, 2, Space.Self);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "HitCube") {
            this.hitComplete = true;
        }
        // 
    }
}
