using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoolingManager : MonoBehaviour
{
    private static PoolingManager _instance;
    //public static PoolingManager Instance => _instance;

    //public List<GameObject> pooledObjects;
    //public GameObject objectToPool;
    //public int amount;
    public static PoolingManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PoolingManager>();
            }
            return _instance;
        }
    }

    [SerializeField]
    private List<PooledItems> pooledLists = new List<PooledItems>();

    [SerializeField]
    private Dictionary<string, List<GameObject>> _items =
        new Dictionary<string, List<GameObject>>();

    void Awake()
    {
        for (int i = 0; i < pooledLists.Count; i++) // Para cada lista de objetos
        {
            PooledItems l = pooledLists[i];
            _items.Add(l.Name, new List<GameObject>()); // creamos una entrada en el dictionary

            for (int j = 0; j < l.amount; j++) // y añadimos las copias
            {
                GameObject tmp;
                tmp = Instantiate(l.objectToPool); // Aqui creamos la copia
                tmp.SetActive(false); // la desactivamos
                _items[l.Name].Add(tmp); // y la añadimos a la lista
            }
        }
    }

    public GameObject GetPooledObject(string name) // Para obtener una copia es necesario especificar el nombre de la lista donde lo vamos a obtener.
    {
        List<GameObject> tmp = _items[name];

        for (int i = 0; i < tmp.Count; i++)
        {
            if (!tmp[i].activeInHierarchy)
            {
                return tmp[i];
            }            
        }

        return null;
    }

    //void Awake()
    //{
    //    if (_instance == null)
    //    {
    //        _instance = this;
    //        DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        Destroy(this); 
    //    }
    //}

    //private void Start()
    //{
    //    pooledObjects = new List<GameObject>();
    //    GameObject tmp;

    //    for (int i = 0; i < amount; i++)
    //    {
    //        tmp = Instantiate(objectToPool);
    //        tmp.SetActive(false);
    //        pooledObjects.Add(tmp);
    //    }
    //}

    //public GameObject GetPooledObject()
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        if (!pooledObjects[i].activeInHierarchy)
    //        {
    //            return pooledObjects[i];
    //        }
    //    }

    //    return null;
    //}
    [Serializable]
    public class PooledItems
    {
        public string Name;
        public GameObject objectToPool;
        public int amount;
    }
}

