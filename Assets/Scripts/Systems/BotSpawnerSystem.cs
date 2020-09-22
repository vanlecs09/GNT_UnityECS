using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[UpdateInGroup(typeof(InitializationSystemGroup))]
public class BotSpawnerSystem : SystemBase
{
    protected override void OnCreate()
    {
        Debug.Log("create");
    }

    protected override void OnUpdate()
    {
    }
}