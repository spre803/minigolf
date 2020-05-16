using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnCapPhysicsSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if(rb == null)
        {
            Debug.LogError("No Rigidbody found on " + gameObject.name);
        }

        rb.maxAngularVelocity = Mathf.Infinity;

        Destroy(this);

    }

}
