using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Move : IComponentData
{
    public float speed;
}
