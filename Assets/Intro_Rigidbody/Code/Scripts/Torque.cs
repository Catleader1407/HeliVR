using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IndiePixel;

public class Torque : Base_RBController
{
    #region Variables
    public float torqueSpeed = 2f;


    #endregion

    #region Custom Methods



    // Update is called once per frame
    protected override void HandlePhysics()
    {
        rb.AddTorque(Vector3.up * torqueSpeed);
    }

    #endregion

}
