using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawnerScript : MonoBehaviour
{
    public List<GameObject> gameobjects = new List <GameObject>();
    public Vector3 center;
    public Vector3 size;
    private int RandomValue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawningObjects");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObjects()
    {
        Vector3 pos = center + transform.localPosition + new Vector3(Random.Range(-size.x/2, size.x/2), Random.Range(-size.y/2, size.y/2), Random.Range(-size.z/2, size.z/2));
        RandomValue = Random.Range(0, gameobjects.Count);
        Instantiate(gameobjects[RandomValue], pos, Quaternion.identity);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }

    IEnumerator spawningObjects()
    {
        while(true)
        {
            SpawnObjects();
            yield return new WaitForSeconds(2f);
        }
    }
}
