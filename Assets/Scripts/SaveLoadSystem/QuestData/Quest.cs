using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public string Id;
    public string Title;
    public string Content;
    public string State; // lock doing complete
    public string Type; // moving attack
    public Vector3 Position;
    public int Progress;
    public int Condition;
}
