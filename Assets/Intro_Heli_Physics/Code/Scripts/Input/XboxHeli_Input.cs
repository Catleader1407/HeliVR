using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class XboxHeli_Input : KeyboardHeli_Input
    {
        #region Custom Method
        protected override void HandleThrottle()
        {
            throttleInput = Input.GetAxis("XboxThrottleUp") + -Input.GetAxis("XboxThrottleDown");
        }
        protected override void HandleCollective()
        {
            collectiveInput = Input.GetAxis("XboxCollective");
        }
        protected override void HandleCyclic()
        {
           cyclicInput.y = Input.GetAxis("XboxCyclicVertical");
           cyclicInput.x = Input.GetAxis("XboxCyclicHorizontal");
        }
        protected override void HandlePedal()
        {
            pedalInput = Input.GetAxis("XboxPedal");
        }
        #endregion

    }
}

