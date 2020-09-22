using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using System;
using UnityEngine;
using Unity.Collections;


[GenerateAuthoringComponent]
public struct TextString : IComponentData
{
    public NativeString64 Value;
}
