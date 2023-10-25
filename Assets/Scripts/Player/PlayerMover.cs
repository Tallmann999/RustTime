using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _movingSpeed;
    [SerializeField] private Animator _animator;

    private Vector3 _direction;
    public Vector3 MainDirection => _direction;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        MovingDirection();
    }

    public void Move()
    {
        _rigidbody.MovePosition(transform.position + _direction * _movingSpeed * Time.deltaTime);
    }

    private void MovingDirection()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        _direction = transform.right * _direction.x + _direction.z * transform.forward;
    }
}
