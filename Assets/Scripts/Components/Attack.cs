using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Attack : IComponentData
{
    public float damage;
    public float range;
    public float coolDown;
    public float deltaTime;
}
