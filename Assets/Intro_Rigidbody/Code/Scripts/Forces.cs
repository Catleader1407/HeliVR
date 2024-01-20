using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : Base_RBController
{
    #region Variables
    public float maxSpeed = 1.0f;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);


    #endregion

    #region Custom Methods
    protected override void HandleForce()
    {
        rb.AddForce(movementDirection * maxSpeed);
    }


    #endregion
}
