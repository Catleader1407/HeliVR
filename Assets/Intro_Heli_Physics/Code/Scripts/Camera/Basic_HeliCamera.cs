using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndiePixel
{
    public class Basic_HeliCamera : Base_HeliCamera, IHeliCamera
    {
        #region Variables
        [Header("Basic Camera Properties")]
 
        public float height = 2f;
        public float distance = 2f;

        private float smoothSpeed = 0.35f;
        #endregion

        #region Builtin Methods
        void Start()
        {
            updateEvent.AddListener(UpdateCamera);
        }
        void OnDisable()
        {
            updateEvent.RemoveListener(UpdateCamera);
        }
        #endregion

        #region Interface Methods
        public void UpdateCamera()
        {
            Vector3 flatfwd = rb.transform.forward;
            flatfwd.y = 0f;
            flatfwd = flatfwd.normalized;

            //Wanted position
            wantedPos = rb.position + (flatfwd * distance) + (Vector3.up * height);

            //Lets position the camera
            transform.position = Vector3.SmoothDamp(transform.position, wantedPos, ref refVelocity, smoothSpeed) ;
            transform.LookAt(lookAtTarget); 
        }
        #endregion
    }
}

