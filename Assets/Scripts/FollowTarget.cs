using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset = new (0, 3, -9);
    
    private void LateUpdate()
    {
        if (!_target) return;
        
        transform.position = _target.position + _offset;
    }
}
