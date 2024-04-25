using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour
{
    public static MenuMgr inst;

    private void Awake()
    {
        inst = this;
    }
}
