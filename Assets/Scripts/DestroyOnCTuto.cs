using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCTuto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyMe();
    }

    public void DestroyMe()
    {
        if (GameManager.Instance.Questions0Acces)
        {
            Debug.Log("zjejziezkje");
            Destroy(gameObject, 0);
        }
    }
}
