using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using System;

[GenerateAuthoringComponent]
public struct Spawn : IComponentData
{
    public Entity prefabEntity;
}
