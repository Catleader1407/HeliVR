using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    #region Variables
    [Header("Weight Properties")]
    public float weightInLbs = 10f;

    public float weight;

    const float lbsToKg = 0.454f;
    const float kgTolbs = 2.205f;
    private Rigidbody rb;
    #endregion

    #region Buildin Methods
    // Start is called before the first frame update
    void Start()
    {
        float finalKG = weightInLbs * lbsToKg;
        weight = finalKG;
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.mass = finalKG;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
