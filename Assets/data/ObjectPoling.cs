using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoling : MonoBehaviour
{
    public static ObjectPoling Instance;
    [SerializeField]private List<GameObject> poolobject = new List<GameObject>();
    [SerializeField] private int AmountToPool=20;
    [SerializeField]
    private GameObject Prefabs;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        //if (Instance != null)
        //{
        //    Instance = this;
        //}
        for(int i = 0; i < AmountToPool; i++)
        {
            Vector2 spawnball = new Vector2(Random.Range(-7, 7), 6);
            GameObject obj=Instantiate(Prefabs,spawnball,Quaternion.identity);
            obj.SetActive(false);
            poolobject.Add(obj);
        }
    }
    public GameObject GetPoolObject()
    {
        for(int i=0; i < poolobject.Count; i++)
        {
            if (!poolobject[i].activeInHierarchy)
            {
                return poolobject[i];
            }
        }
        return null;
    }
 
}
