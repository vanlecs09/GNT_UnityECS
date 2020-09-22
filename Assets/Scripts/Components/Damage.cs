using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Damage : IComponentData
{
    public float value;
}
