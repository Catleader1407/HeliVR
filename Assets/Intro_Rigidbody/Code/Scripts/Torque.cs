using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    #region Variables
    public float torqueSpeed = 2f;

    private Rigidbody rb;
    #endregion

    #region Builtin Methods
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb)
        {
            rb.AddTorque(Vector3.up * torqueSpeed);
        }
    }
    #endregion
}
