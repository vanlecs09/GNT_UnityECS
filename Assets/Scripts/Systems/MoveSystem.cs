using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using UnityEngine;

public class MoveSystem : SystemBase
{
    protected override void OnCreate()
    {

    }
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities
            .WithName("MoveSystem")
            .ForEach((ref Translation translation, in Move move, in Direction dir) =>
            {
                translation.Value = translation.Value + dir.value * move.speed * deltaTime;
            })
            .ScheduleParallel();
    }
}