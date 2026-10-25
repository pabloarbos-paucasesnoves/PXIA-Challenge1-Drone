using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _maxHealth = 20f;

    [SerializeField] private float _minimumX = -5f;
    [SerializeField] private float _maximumX = 5f;
    [SerializeField] private float _minimumY = 1f;
    [SerializeField] private float _maximumY = 5f;
    
    private const float MinimumHealth = 0f;
    private float _currentHealth;

    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;

        Debug.Log($"Vida actual: {_currentHealth}");
        
        if (_currentHealth > MinimumHealth) return;
        
        Debug.Log("BOOM!");
        
        Destroy(gameObject);
    }
    
    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        ManageDroneMovement();
        LimitDroneMovement();
    }

    private void ManageDroneMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        
        transform.Translate(movement);
    }

    private void LimitDroneMovement()
    {
        Vector3 position = transform.position;
        
        position.x = Mathf.Clamp(position.x, _minimumX, _maximumX);
        position.y = Mathf.Clamp(position.y, _minimumY, _maximumY);
        
        transform.position = position;
    }
}
