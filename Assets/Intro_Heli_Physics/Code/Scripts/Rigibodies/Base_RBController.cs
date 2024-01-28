using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    [RequireComponent(typeof(Rigidbody))]
    public class Base_RBController : MonoBehaviour
    {
        #region Variables
        [Header("Base Properties")]
        public float weightInLbs = 1200f;
        public Transform cog; //cog = center of gravity        

        const float lbsToKg = 0.454f;
        const float kgTolbs = 2.205f;

        protected Rigidbody rb;
        public float weight;
        #endregion

        #region Buildin Methods
        // Start is called before the first frame update
        public virtual void Start()
        {
            float finalKG = weightInLbs * lbsToKg;
            weight = finalKG;
            rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.mass = weight;
            }            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (rb)
            {
                HandlePhysics();                
            }
        }
        #endregion

        #region Custom Methods
        protected virtual void HandlePhysics() { }
        #endregion
    }

}
