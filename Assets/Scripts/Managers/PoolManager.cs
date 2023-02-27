using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // Prefab array
    public GameObject[] prefabs;

    // Pool List
    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for(int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int idx)
    {
        GameObject select = null;

        // null object approach
        foreach (GameObject item in pools[idx])
        {
            if(!item.activeSelf) // check active status
            {
                // find and assign the select var
                select = item;
                select.SetActive(true);
                break;
            }
        }

        // if select is null,
        if(!select)
        {
            select = Instantiate(prefabs[idx], transform);
            pools[idx].Add(select);
        }

        return select;
    }
}
