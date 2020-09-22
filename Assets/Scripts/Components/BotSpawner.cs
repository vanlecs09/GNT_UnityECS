using Unity.Entities;
using Unity.Mathematics;
namespace AutoFarmers
{
    [GenerateAuthoringComponent]
    public struct BotSpawner : IComponentData
    {
        public Entity BotPrefab;
    }
}