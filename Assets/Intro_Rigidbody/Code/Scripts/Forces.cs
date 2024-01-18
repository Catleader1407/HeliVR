using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    #region Variables
    public float maxSpeed = 1.0f;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);

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
            rb.AddForce(movementDirection * maxSpeed);
        }
    }
    #endregion
}
