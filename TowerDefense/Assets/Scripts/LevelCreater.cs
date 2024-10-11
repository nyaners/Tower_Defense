using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreater : MonoBehaviour
{
    [Header("Settings:")]
    [SerializeField]
    private  int NODE_GRIDE_ROW_COUNT = 4;
    [SerializeField]
    private  int NODE_GRIDE_COLUMN_COUNT = 4;
    [SerializeField]
    [Tooltip("Pref")]
    private float offset = 1f;

    [Space(10)]
    [Header("Prefabs:")]
    [SerializeField]
    private GameObject nodePrefab;

    [Space(10)]
    [SerializeField]
    private Transform nodeParent;
    private void Start()
    {

    }

    [ContextMenu("Create Nodes")]
    private void CreateNodes()
    {
        if (transform.childCount > 0)
        {
          //  foreach (Transform child in transform.GetComponentsInChildren<Transform>())
          //  {
          //      DestroyImediate(child.gameObject);
          //  }
             
        }
        for (int x = 0; x < NODE_GRIDE_ROW_COUNT; x++)
        {
            for (int z = 0; z < NODE_GRIDE_COLUMN_COUNT; z++)
            {
                GameObject obj = Instantiate(nodePrefab, new Vector3(x * offset, 0, z * offset), Quaternion.identity, nodeParent);
                obj.name = "Node:" + x + " " + z;
            }
        }
    }
}
