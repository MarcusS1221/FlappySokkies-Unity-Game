using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public PipeSpawner pSpawner;
    public GameObject chickenprefab;

    //Chicken
    public float spawnRate = 1f;
    public float chickenminHeight = -1f;
    public float chickenmaxHeight = 1f;
    
    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnChicken), spawnRate, spawnRate);

    }

    private void OnDissable()
    {
        CancelInvoke(nameof(SpawnChicken));
    }

    public Vector3 test = new Vector3(0,1,0);
    
    private void SpawnChicken()
    {
        GameObject chicken = Instantiate(chickenprefab, transform.position, Quaternion.identity);

        chicken.transform.position += new Vector3(0,pSpawner.chickentest,0);
    }
}
