using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    public GameObject[] cevre;
    public int zPos = 60;
    public bool creatingCevre = false;
    public int secNum;

    void Update()
    {
        if (creatingCevre == false)
        {
            creatingCevre = true;
            StartCoroutine(GenerateCevre());
        }
    }

    IEnumerator GenerateCevre()
    {
        secNum = Random.Range(0, 2);
        Instantiate(cevre[secNum], new Vector3((float)-3.770851,(float) 0.2469234, zPos), Quaternion.identity);
        zPos += 60;
        yield return new WaitForSeconds(3);
        creatingCevre = false;
    }
}
