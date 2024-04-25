using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CourseData : ScriptableObject
{
    public int courseNum = -1;
    public float maxTime = 0.0f;
    public List<(float, string, string)> leaderboard = new List<(float, string, string)>();
}

