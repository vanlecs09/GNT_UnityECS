using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class PrefabEntities : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{
    public GameObject gameObjectPrefab;
    public static Entity entityPrefab;
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        PrefabEntities.entityPrefab = conversionSystem.GetPrimaryEntity(gameObjectPrefab);
    }


    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(this.gameObjectPrefab);
    }

}