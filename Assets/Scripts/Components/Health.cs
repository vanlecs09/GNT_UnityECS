using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Health : IComponentData
{
    public float value;
}
