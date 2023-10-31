using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTrail : MonoBehaviour
{
    [SerializeField] private float _activeTime = 0.1f;
    [SerializeField] private float _meshRefreshRate = 0.05f;
    [SerializeField] private float _meshDestroyDelay = 0.08f;

    [SerializeField] Transform _positionToSpawn;
    [SerializeField] Material _mat;

    [SerializeField] private string _shaderVarRef;
    [SerializeField] private float _shaderVarRate = 0.1f;
    [SerializeField] private float _shaderVarRefreshRate = 0.05f;

    private bool _isTrailActive;
    private SkinnedMeshRenderer _skinnedMeshRenderers;

    public void StartCharacterTrail()
    {
        if (!_isTrailActive)
        {
            _isTrailActive = true;
            StartCoroutine(ActivateTrail(_activeTime));
        }
    }

    IEnumerator ActivateTrail(float timeActive)
    {
        while (timeActive > 0)
        {
            timeActive -= _meshRefreshRate;

            if (_skinnedMeshRenderers == null)
            {
                _skinnedMeshRenderers = GetComponent<SkinnedMeshRenderer>();
            }

            GameObject gameObject = new GameObject();
            gameObject.transform.SetPositionAndRotation(_positionToSpawn.position, _positionToSpawn.rotation);

            MeshRenderer mr = gameObject.AddComponent<MeshRenderer>();
            MeshFilter mf = gameObject.AddComponent<MeshFilter>();

            Mesh mesh = new Mesh();
            _skinnedMeshRenderers.BakeMesh(mesh);

            mf.mesh = mesh;
            mr.material = _mat;

            StartCoroutine(AnimateMaterialFloat(mr.material, 0f, _shaderVarRate, _shaderVarRefreshRate));

            Destroy(gameObject, _meshDestroyDelay);

            yield return new WaitForSeconds(_meshRefreshRate);
        }
        _isTrailActive = false;
    }

    IEnumerator AnimateMaterialFloat(Material mat, float goal, float rate, float refreshRate)
    {
        float valueToAnimate = mat.GetFloat(_shaderVarRef);

        while (valueToAnimate > goal)
        {
            valueToAnimate -= rate;
            mat.SetFloat(_shaderVarRef, valueToAnimate);
            yield return new WaitForSeconds(refreshRate);
        }
    }
}
