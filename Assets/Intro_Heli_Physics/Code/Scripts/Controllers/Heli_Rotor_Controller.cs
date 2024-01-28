using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace IndiePixel
{
    public class Heli_Rotor_Controller : MonoBehaviour
    {
        #region Variables
        private List<IHeliRotor> rotors;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            rotors = GetComponentsInChildren<IHeliRotor>().ToList<IHeliRotor>();
        }
        #endregion

        #region Custom Methods
        public void UpdateRotors(Input_Controller input, float currentRPMs)
        {
            //Degerees per second calculation
            float dps = ((currentRPMs * 360f) / 60f) *Time.deltaTime;
            //Debug.Log("Dps = " + dps);
            //Debug.Log("Time " + Time.deltaTime);

            //Update the rotors
            //Debug.Log("Rotor Controller");
            if (rotors.Count > 0)
            {
                foreach (var rotor in rotors)
                {
                    rotor.UpdateRotor(dps,input); 
                }
            }
        }
        #endregion
    }
}

