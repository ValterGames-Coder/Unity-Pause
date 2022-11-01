using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float StartSpeed;
    private void Start()
    {
        StartSpeed = _speed;
        Pause.instance.IsPause += SetPause;
    }

    private void Update()
    {
        transform.position += Vector3.right * _speed * Time.deltaTime;
    }
    
    private void SetPause(bool pause)
    {
        _speed = pause ? 0 : StartSpeed;
    }
}