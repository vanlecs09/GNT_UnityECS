using System;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Rendering;

[Serializable]
public class GameObjectPrefab
{
    public GameObject gameObjectPrefab;
}

[Serializable]
public class StringPrefabDictionary : SerializableDictionaryBase<string, GameObjectPrefab> { }
public class EntityTemplateService : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{
    [SerializeField]
    StringPrefabDictionary _mapGameObject = new StringPrefabDictionary();
    public static Dictionary<string, Entity> _mapEntity = new Dictionary<string, Entity>();
    private static EntityManager _entityManager;
    // public static EntityTemplateService Instance
    // {
    //     get { return ((EntityTemplateService)_Instance); }
    //     set { _Instance = value; }
    // }

    public static Entity _entityPrefab;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        foreach (var goPrefabKey in _mapGameObject.Keys)
        {
            var goPrefab = _mapGameObject[goPrefabKey];
            var entityPrefab = conversionSystem.GetPrimaryEntity(goPrefab.gameObjectPrefab);
            _mapEntity.Add(goPrefabKey, entityPrefab);
            _entityPrefab = entityPrefab;
        }
    }


    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        foreach (var goPrefab in _mapGameObject.Values)
            referencedPrefabs.Add(goPrefab.gameObjectPrefab);
    }

    public static void Spawn(string entityName, float3 position)
    {
        if (_entityManager == default)
            _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        Entity entityPrefab = Entity.Null;
        _mapEntity.TryGetValue(entityName, out entityPrefab);
        if (entityPrefab != Entity.Null)
        {
            Debug.Log("spawn entity");
            var entity = _entityManager.Instantiate(entityPrefab);
            _entityManager.SetComponentData(entity, new Translation { Value = position });
        }
    }

    public static void SpawnText(string entityName, float3 position, float damage)
    {
        if (_entityManager == default)
            _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        Entity entityPrefab = Entity.Null;
        _mapEntity.TryGetValue(entityName, out entityPrefab);
        if (entityPrefab != Entity.Null)
        {
            Debug.Log("spawn entity");
            var entity = _entityManager.Instantiate(entityPrefab);
            _entityManager.SetComponentData(entity, new Translation { Value = position });
            _entityManager.SetComponentData(entity, new TextString { Value = damage.ToString() });
        }
    }
}