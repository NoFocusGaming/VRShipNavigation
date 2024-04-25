using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMgr : MonoBehaviour
{
    public static SceneMgr inst;

    private void Awake()
    {
        inst = this;
    }
}
