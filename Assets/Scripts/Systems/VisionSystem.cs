using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class VisionSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.WithAll<Team, Target>()
        .ForEach((Entity entity, ref Team team, ref Target target, ref Translation trans, ref Vision vision) =>
        {
            var teamAValue = team.value;
            var pos = trans.Value;
            var _target = target;
            var _team = team;
            var _vision = vision;
            float closetDistance = float.MaxValue;
            float3 closetPos = float3.zero;
            var closetEntity = Entity.Null;
            Entities.WithAll<Team, Target>()
            .ForEach((Entity entityTarget, ref Team targetTeam, ref Translation transTarget) =>
            {
                if (_team.value == targetTeam.value) return;
                var distanceToTarget = math.distance(pos, transTarget.Value);
                if (distanceToTarget < closetDistance && distanceToTarget < _vision.range)
                {
                    closetDistance = math.distance(pos, transTarget.Value);
                    closetEntity = entityTarget;
                    closetPos = transTarget.Value;
                }
            });

            target.position = closetPos;
            target.targetEntity = closetEntity;
        });
    }
}