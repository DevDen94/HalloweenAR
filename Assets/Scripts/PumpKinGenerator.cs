using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpKinGenerator : MonoBehaviour
{
    [SerializeField] GameObject Pumpkin;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MainRoutine());
    }


    IEnumerator MainRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2,5));
            StartCoroutine(GenerateRoutine());
        }
            
        
    }


    IEnumerator GenerateRoutine()
    {
        Vector3 position;
        position.x = Random.Range(-20, 20);
        position.y = Random.Range(-20, 20);
        position.z = Random.Range(-20, 20);


        Instantiate(Pumpkin, position, Quaternion.identity);
        yield return new WaitForSeconds(0);
    }


}
