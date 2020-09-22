using Unity.Entities;
using UnityEngine;

[RequiresEntityConversion]
[AddComponentMenu("DOTS Samples/FixedTimestepWorkaround/Team")]
[ConverterVersion("joe", 1)]
public class AddShareComponentAuthorize : MonoBehaviour, IConvertGameObjectToEntity
{
    public TEAM team;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        // var data = new ProjectileSpawnTime { SpawnTime = SpawnTime };
        // dstManager.AddSharedComponentData(entity, new Team { value = team });
    }
}