using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndiePixel
{
    public enum InputType
    {
        Keyboard,
        Xbox,
        Mobile,
    }

    [RequireComponent(typeof(KeyboardHeli_Input), typeof(XboxHeli_Input))]
    public class Input_Controller : MonoBehaviour
    {

        #region Variables
        [Header("Input Properties")]
        public InputType inputType = InputType.Keyboard;
        
        private KeyboardHeli_Input keyInput;
        private XboxHeli_Input xboxInput;
        #endregion

        #region Properties
        private float throttleInput;
        public float ThrottleInput
        {
            get { return throttleInput; }
        }
        private float stickyThrottle;
        public float StickyThrottle
        {
            get { return stickyThrottle; }
        }
        private float collectiveInput;
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }
        private float stickyCollectiveInput;
        public float StickyCollectiveInput
        {
            get { return stickyCollectiveInput; }
        }

        private Vector2 cyclicInput;
        public Vector2 CyclicInput
        {
            get { return cyclicInput; }
        }
        private float pedalInput;
        public float PedalInput
        {
            get { return pedalInput; }
        }
        #endregion

        #region Buildin Methods
        void Start()
        {
            keyInput = GetComponent<KeyboardHeli_Input>();
            xboxInput = GetComponent<XboxHeli_Input>();

            if (keyInput && xboxInput)
            {
                SetInputType(inputType);
            }
                
        }
        private void Update()
        {
            switch (inputType)
            {
                case InputType.Keyboard:
                    throttleInput = keyInput.RawThrottleInput;
                    collectiveInput = keyInput.CollectiveInput;
                    cyclicInput = keyInput.CyclicInput;
                    pedalInput = keyInput.pedalInput;
                    stickyThrottle = keyInput.StickyThrottle;
                    stickyCollectiveInput = keyInput.StickyCollectiveInput;
                    break;

                case InputType.Xbox:
                    throttleInput = xboxInput.RawThrottleInput;
                    collectiveInput = xboxInput.CollectiveInput;
                    cyclicInput = xboxInput.CyclicInput;
                    pedalInput = xboxInput.pedalInput;
                    stickyThrottle = xboxInput.StickyThrottle;
                    stickyCollectiveInput = xboxInput.StickyCollectiveInput;
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Custom Methods
        void SetInputType(InputType type)
        {
            if (type == InputType.Keyboard)
            {
                keyInput.enabled = true;
                xboxInput.enabled = false;
            }

            if (type == InputType.Xbox)
            {
                keyInput.enabled = false;
                xboxInput.enabled = true;
            }
        }
        #endregion
    }

}
