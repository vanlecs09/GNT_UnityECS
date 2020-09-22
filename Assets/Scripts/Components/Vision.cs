using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Vision : IComponentData
{
    public float range;
}
