using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    public GameObject[] MyObjects {
        get { return myObjects; }
    }
    public void createBall(int index, Vector3 position)
    {
        // int randomIndex = Random.Range(0, myObjects.Length);
            Debug.Log("Spawn");
        Instantiate(myObjects[index], position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        createBall(Random.Range(0, 2), new Vector3(0f,0f,0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            createBall(Random.Range(0, 2), new Vector3(0f,0f,0f));

        }
    }


}
