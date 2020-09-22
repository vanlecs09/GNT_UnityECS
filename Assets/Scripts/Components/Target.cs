using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using System;

[GenerateAuthoringComponent]
public struct Target : IComponentData
{
    public float3 position;
    public Entity targetEntity;
}
