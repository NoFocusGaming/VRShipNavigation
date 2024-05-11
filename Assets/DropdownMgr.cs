using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Controls the images from the dropdown
    /// </summary>
    public class DropdownMgr : MonoBehaviour
    {
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;
        }

        [SerializeField]
        List<Step> m_StepList = new List<Step>();

        public void OptionA()
        {
            m_StepList[0].stepObject.SetActive(true);
            m_StepList[1].stepObject.SetActive(false);
            m_StepList[2].stepObject.SetActive(false);
        }
    }
}
