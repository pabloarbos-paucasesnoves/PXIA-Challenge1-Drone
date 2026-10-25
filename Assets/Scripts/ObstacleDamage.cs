using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    [SerializeField] private float _damage = 5f;

    private void OnTriggerEnter(Collider other)
    {
        var droneController = other.GetComponentInParent<DroneController>();

        if (!droneController) return;

        droneController.TakeDamage(_damage);
        Destroy(gameObject);
    }
}
