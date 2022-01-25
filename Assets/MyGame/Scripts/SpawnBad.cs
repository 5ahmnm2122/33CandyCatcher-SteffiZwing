using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBad : MonoBehaviour
{
    public Bad1 bad1Prefab;
    public Bad2 bad2Prefab;

    public GameObject badParent;

    private void Update()
    {

    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnBadObjects1();

            yield return new WaitForSeconds(3);
            SpawnBadObjects2();
        }

    }

    private void SpawnBadObjects1()
    {
        Bad1 bad1Clone = (Bad1)Instantiate(bad1Prefab, transform.position, transform.rotation);
        float bad1Size = 0.3f;
        bad1Clone.transform.localScale = new Vector3(bad1Size, bad1Size, 0);
        bad1Clone.transform.SetParent(badParent.transform);
        bad1Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), badParent.transform.position.y, 0f);
        bad1Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

    private void SpawnBadObjects2()
    {
        Bad2 bad2Clone = (Bad2)Instantiate(bad2Prefab, transform.position, transform.rotation);
        float bad2Size = 0.3f;
        bad2Clone.transform.localScale = new Vector3(bad2Size, bad2Size, 0);
        bad2Clone.transform.SetParent(badParent.transform);
        bad2Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), badParent.transform.position.y, 0f);
        bad2Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

}