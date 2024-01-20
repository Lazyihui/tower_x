using System;
using UnityEngine;

[CreateAssetMenu(fileName = "RoleTm", menuName = "Template/RoleTm")]

// ScriptableObject 有了这个可以在面板上编辑
public class RoleTM : ScriptableObject
{
    public int typeID;
    public float moveSpeed;
}