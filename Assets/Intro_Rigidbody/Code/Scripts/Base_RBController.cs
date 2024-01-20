using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_RBController : MonoBehaviour
{
    #region Variables
    protected Rigidbody rb;
    #endregion

    #region Buildin Methods
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
            HandleForce();
            HandleTorque();
        }
    }
    #endregion

    #region Custom Methods
    protected virtual void HandleForce() { }
    protected virtual void HandleTorque() { }
    #endregion
}
