using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class DamageSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.WithAll<Health, Damage, Translation>()
        .ForEach((Entity entity, ref Health health, ref Damage damage) =>
        {
            health.value -= damage.value;
            EntityManager.RemoveComponent<Damage>(entity);
            var trans = EntityManager.GetComponentData<Translation>(entity);
            EntityTemplateService.SpawnText("123", trans.Value, damage.value);
        });
    }
}