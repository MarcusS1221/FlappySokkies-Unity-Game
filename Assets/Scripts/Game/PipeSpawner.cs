using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab;

    //pipes    
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    public float chickentest;

    public float avgPos;
   
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);

    }

    private void OnDissable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);

        avgPos = Random.Range(minHeight, maxHeight);
        chickentest = avgPos / 2;

    
        pipes.transform.position += Vector3.up * avgPos;

    }

}
