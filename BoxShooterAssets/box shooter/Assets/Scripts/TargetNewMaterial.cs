using UnityEngine;
using System.Collections;

public class TargetNewMaterial : MonoBehaviour {

    public Material broken_material;

    private Renderer renderer;


    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    void OnCollisionEnter (Collision newCollision)
    {
        if (broken_material != null)
        {
            renderer.material = broken_material;
            broken_material = null;
        }
    }
}
