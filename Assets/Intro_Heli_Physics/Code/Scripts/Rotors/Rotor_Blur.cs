using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.XR;

namespace IndiePixel
{
    public class Rotor_Blur : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Rotor Blur Properties")]
        public float maxDps = 1000f;
        public List<GameObject> blades = new List<GameObject>();
        public GameObject blurGeo;

        public List<Texture2D> blurTextures = new List<Texture2D>();
        public Material blurMat;
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            float normalizeDPS = Mathf.InverseLerp(0f, maxDps, dps);            
            int blurTextID = Mathf.FloorToInt(normalizeDPS * blurTextures.Count -1);
            blurTextID = Mathf.Clamp(blurTextID, 0, blurTextures.Count - 1);

            //Debug.Log(gameObject + "'s Dps = " + dps);
            //Debug.Log(gameObject + "'s NormalizeDPS = " + normalizeDPS);
            //Debug.Log(gameObject + "'s BlueTextID =" + blurTextID);                         


            //Check to see if we have blur Textures and A blur Mat(erial)
            if (blurMat && blurTextures.Count > 0)
            {
                blurMat.SetTexture("_MainTex", blurTextures[blurTextID]);
                
            }
            if (blurTextID > 2 && blades.Count > 0)
            {
                HandleGeoBladeViz(false);
            }
            else
            {
                HandleGeoBladeViz(true);
            }
        }

        void HandleGeoBladeViz(bool viz)
        {
            foreach (var blade in blades)
            {
                blade.SetActive(viz);
            }
        }
        #endregion
    }
}

