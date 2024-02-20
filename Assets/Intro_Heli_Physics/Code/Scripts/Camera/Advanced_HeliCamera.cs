using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class Advanced_HeliCamera : Base_HeliCamera, IHeliCamera
    {
        #region Variables
        [Header("Advanced Camera Properties")]
        public float minDistance = 4f;
        public float maxDistance = 8f;
        #endregion


        #region Builtin Methods        
        void Start()
        {
            updateEvent.AddListener(UpdateCamera);
        }
        #endregion
        private void OnDisable()
        {
            updateEvent.RemoveListener(UpdateCamera);
        }
        #region Interface Methods
        public void UpdateCamera()
        {

        }
        #endregion

        #region Custom Methods
        #endregion
    }

}
