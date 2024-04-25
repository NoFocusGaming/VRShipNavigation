using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseMgr : MonoBehaviour
{
    public static CourseMgr inst;

    private void Awake()
    {
        inst = this;
    }
}
