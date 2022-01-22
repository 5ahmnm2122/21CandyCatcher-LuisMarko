using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTire : MonoBehaviour
{
    public Tire tirePrefab;
    public GameObject badParent;

    private void Update()
    {
        
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnTire_();
        }

    }

    private void SpawnTire_()
    {
        Tire tireClone = (Tire)Instantiate(tirePrefab, transform.position, transform.rotation);
        float tireSize = 0.15f;
        tireClone.transform.localScale = new Vector3(tireSize, tireSize, 0);
        tireClone.transform.SetParent(badParent.transform);
        tireClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), badParent.transform.position.y, 0f);
        tireClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

}