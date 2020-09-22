using Unity.Entities;
using Unity.Mathematics;

using Unity.Transforms;

[GenerateAuthoringComponent]
public struct Team : IComponentData
{
    public TEAM value;
}
public enum TEAM
{
    A,
    B
}