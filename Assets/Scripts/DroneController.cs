using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _maxHealth = 20f; 
    
    private const float MinimumHealth = 0f;
    private float _currentHealth;

    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;

        if (_currentHealth > MinimumHealth) return;
        
        Destroy(gameObject);
    }
    
    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void FixedUpdate()
    {
        ManageDroneMovement();
    }

    private void ManageDroneMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        
        transform.Translate(movement);
    }
}
