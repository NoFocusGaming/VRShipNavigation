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
        [SerializeField]
        public TMP_Dropdown currDropdown;
        
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;
        }

        [SerializeField]
        List<Step> m_StepList = new List<Step>();

        public void ChangeOption()
        {
            int currIndex = currDropdown.value;

            foreach (Step image in m_StepList){
                image.stepObject.SetActive(false);
            }
            m_StepList[currIndex].stepObject.SetActive(true);
        }
    }
}
