using UnityEngine;

sealed class PingPong : MonoBehaviour
{
    [SerializeField] float _frequency = 1;
    [SerializeField] float _width = 1;

    float _base;

    void Start()
      => _base = transform.localPosition.z;

    void Update()
      => transform.localPosition = Vector3.forward * (Mathf.Cos(Time.time * _frequency * Mathf.PI * 2) * _width + _base);
}
