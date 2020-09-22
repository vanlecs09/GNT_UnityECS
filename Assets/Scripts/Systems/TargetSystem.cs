using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class TargetSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.WithAll<Team, Target>()
        .ForEach((Entity entity, ref Translation trans, ref Target target, ref Direction dir) =>
        {
            var _target = target;
            // if(_target.)
            if(target.targetEntity == null) return;
            dir.value = target.position - trans.Value;
        });
    }
}