using Unity.Entities;
using Unity.Rendering;

[UpdateInGroup(typeof(InitializationSystemGroup))]
public class HacksSystem : ComponentSystem
{
    protected override void OnCreate()
    {
        World.GetOrCreateSystem<CopySkinnedEntityDataToRenderEntity>().Enabled = false;
    }
    protected override void OnUpdate()
    {
        /* Suppresses the error: "ArgumentException: A component with type:BoneIndexOffset has not been added to the entity.", until the Unity bug is fixed. */
        World.GetOrCreateSystem<CopySkinnedEntityDataToRenderEntity>().Enabled = false;
    }
}