using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCandy : MonoBehaviour
{
    public Candy_1 candy1Prefab;
    public Candy_2 candy2Prefab;
    public Candy_3 candy3Prefab;
    
    public GameObject candyParent;

    IEnumerator Start()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1);
            SpawnCandy_1();
            yield return new WaitForSeconds(1);
            SpawnCandy_2();
            yield return new WaitForSeconds(1);
            SpawnCandy_3();
        }

    }

    void SpawnCandy_1()
    {
        Candy_1 candy1Clone = (Candy_1)Instantiate(candy1Prefab, transform.position, transform.rotation);
        float candy1Size = 0.2f;

        candy1Clone.transform.localScale = new Vector3(candy1Size, candy1Size, 0);

        candy1Clone.transform.SetParent(candyParent.transform);

        candy1Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), candyParent.transform.position.y, 0f);

        candy1Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(0, 0), UnityEngine.Random.Range(-5, -5));
    }

    private void SpawnCandy_2()
    {
        Candy_2 candy2Clone = (Candy_2)Instantiate(candy2Prefab, transform.position, transform.rotation);
        float candy2Size = 0.2f;

        candy2Clone.transform.localScale = new Vector3(candy2Size, candy2Size, 0);
        candy2Clone.transform.SetParent(candyParent.transform);

        candy2Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), candyParent.transform.position.y, 0f);

        candy2Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -5));
    }

    private void SpawnCandy_3()
    {
        Candy_3 candy3Clone = (Candy_3)Instantiate(candy3Prefab, transform.position, transform.rotation);
        float candy3Size = 0.2f;

        candy3Clone.transform.localScale = new Vector3(candy3Size, candy3Size, 0);
        candy3Clone.transform.SetParent(candyParent.transform);

        candy3Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), candyParent.transform.position.y, 0f);

        candy3Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -5));
    }   
}
