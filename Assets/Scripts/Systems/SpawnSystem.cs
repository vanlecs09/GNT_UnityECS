// using Unity.Entities;
// using Unity.Transforms;
// using Unity.Mathematics;
// using Unity.Jobs;
// using Unity.Collections;
// using UnityEngine;

// public class SpawnSystem : ComponentSystem
// {
//     private float spawnCoolDown = 0.5f;
//     protected override void OnUpdate()
//     {
//         spawnCoolDown -= Time.DeltaTime;
//         if (spawnCoolDown < 0)
//         {
//             spawnCoolDown = 0.5f;
//             // Entities.ForEach((Entity entity, ref Spawn spawn) =>
//             // {
//                 // Entity newEntity = EntityManager.Instantiate(PrefabEntities.entityPrefab);
//             // });
//         }

//     }
// }