using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : Base_RBController
{
    #region Variables
    public float torqueSpeed = 2f;


    #endregion

    #region Custom Methods



    // Update is called once per frame
    protected override void HandleTorque()
    {
        rb.AddTorque(Vector3.up * torqueSpeed);
    }
    
    #endregion

}
