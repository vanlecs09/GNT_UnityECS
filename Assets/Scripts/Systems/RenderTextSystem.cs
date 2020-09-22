using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public class RenderTextSystem : ComponentSystem
{
    private float spawnCoolDown = 0.5f;
    protected override void OnUpdate()
    {
        Entities.ForEach(( ref TextString text,  TextMesh textMesh) =>
        {
            textMesh.text = text.Value.ToString();
        });
    }
}