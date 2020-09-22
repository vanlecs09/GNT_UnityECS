using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class AttackSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;
        Entities.WithAll<Attack, Target>()
        .ForEach((Entity entity, ref Translation trans, ref Attack attack, ref Target target) =>
        {
            if (target.targetEntity == null) return;
            var distanceToTarget = math.distance(trans.Value, target.position);
            if (distanceToTarget < attack.range)
            {
                attack.deltaTime += Time.DeltaTime;
                if (attack.deltaTime > attack.coolDown)
                {
                    attack.deltaTime = 0;
                    EntityManager.AddComponentData(target.targetEntity, new Damage
                    {
                        value = attack.damage
                    });
                }
            }
            else
            {
                attack.deltaTime = 0;
            }
        });
    }
}