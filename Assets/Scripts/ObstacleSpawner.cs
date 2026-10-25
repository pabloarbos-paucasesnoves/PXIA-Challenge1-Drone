using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _spawnInterval = 3f;
    
    private float _spawnIntervalTimer;
    
    private void Update()
    {
        _spawnIntervalTimer += Time.deltaTime;

        if (_spawnIntervalTimer < _spawnInterval) return;

        SpawnObstacle();
        _spawnIntervalTimer = 0f;
    }

    private void SpawnObstacle()
    {
        Vector3 randomPosition = new (
            Random.Range(-5f, 5f),
            Random.Range(1f, 5f),
            0f
        );
        
        Instantiate(_obstaclePrefab, randomPosition, Quaternion.identity);
    }
}
