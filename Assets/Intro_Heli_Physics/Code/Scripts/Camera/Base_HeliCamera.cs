using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace IndiePixel
{
    public class Base_HeliCamera : MonoBehaviour
    {
        #region Variables
        [Header("Base Camera properties")]

        public Rigidbody rb;
        public Transform lookAtTarget;

        protected Vector3 wantedPos;
        protected Vector3 refVelocity;

        protected UnityEvent updateEvent = new UnityEvent();
        #endregion

        #region Builtin methods
        // Start is called before the first frame update
        void Start()
        {

        }
        void FixedUpdate()
        {
            if (rb)
            {
                updateEvent.Invoke();
            }
        }
        #endregion

        #region Custom Methods        
        #endregion
    }
}

