using UnityEngine;

sealed class Jump : MonoBehaviour
{
    [SerializeField] Vector3 _positionA = Vector3.zero;
    [SerializeField] Vector3 _positionB = Vector3.forward;

    bool _toggle;

    void Start()
      => transform.localPosition = _positionA;

    void Update()
    {
        _toggle ^= Input.GetKeyDown(KeyCode.Space);
        transform.localPosition = _toggle ? _positionB : _positionA;
    }
}
