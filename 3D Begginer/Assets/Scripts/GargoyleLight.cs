using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleLight : MonoBehaviour
{
    public SkinnedMeshRenderer mRender;

    void Start()
    {
        mRender = gameObject.GetComponent<SkinnedMeshRenderer>();

        Color nuevoColor = mRender.materials[0].color;

        nuevoColor.a = 0f;

        mRender.materials[0].color = nuevoColor;
    }

    public void Lantern(float color)
    {
        Color nuevoColor = mRender.materials[0].color;

        nuevoColor.a = color;

        mRender.materials[0].color = nuevoColor;
    }
}
