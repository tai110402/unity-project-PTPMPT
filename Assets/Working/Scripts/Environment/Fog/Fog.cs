using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    [Range(0f, 0.04f)]
    [SerializeField] private float _fogDensity = 0.04f;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fogDensity = _fogDensity;

        RenderSettings.fog = true;
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.fogDensity = _fogDensity;
    }
}
