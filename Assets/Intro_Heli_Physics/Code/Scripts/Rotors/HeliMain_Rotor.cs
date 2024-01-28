using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace IndiePixel
{
    public class HeliMain_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Main Rotor Properties")]
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 35f;
        #endregion

        #region Properties
        private float currentRPMs;
        public float CurrentRPMs
        {
            get { return currentRPMs; }
        }
        #endregion

        #region Buildin Methods
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            //Debug.Log("Main Rotor");
            currentRPMs = (dps / 360f) * 60f /Time.deltaTime;
            //Debug.Log(currentRPMs);
            transform.Rotate(Vector3.up, dps);
            //Pitch the blased up and down

            if(lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(-input.StickyCollectiveInput * maxPitch, 0f, 0f);
                rRotor.localRotation = Quaternion.Euler(input.StickyCollectiveInput * maxPitch, 0f, 0f);
            }
        } 
        #endregion

    }

}
