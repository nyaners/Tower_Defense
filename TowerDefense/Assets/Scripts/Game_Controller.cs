using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    private const int NODE_GRIDE_ROW_COUNT = 4;

    [SerializeField]
    private GameObject nodePrefab;
    void Start()
    {
        CreateNodes();
    }

    private void CreateNodes()
    {
        for (int x = 0; x < NODE_GRIDE_ROW_COUNT; x++)
        {
            for (int z = 0; z < NODE_GRIDE_ROW_COUNT; z++)
            {
                Instantiate(nodePrefab, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}
