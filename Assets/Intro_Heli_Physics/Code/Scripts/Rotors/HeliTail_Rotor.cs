using IndiePixel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class HeliTail_Rotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Tail Rotor Properties")]
        public float rotationSpeedModifier = 1.5f;
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 45f;
        #endregion

        #region Buildin Methods
        // Start is called before the first frame update
        void Start()
        {

        }
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            //Debug.Log("Tail Rotor");
            transform.Rotate(Vector3.right, dps * rotationSpeedModifier);

            if (lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(0f, input.PedalInput * maxPitch, 0f);
                rRotor.localRotation = Quaternion.Euler(0f, -input.PedalInput * maxPitch, 0f);
            }
        }
        #endregion

    }
}

