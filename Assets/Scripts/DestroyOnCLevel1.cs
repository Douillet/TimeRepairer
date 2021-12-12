using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCLevel1 : MonoBehaviour
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
        if (GameManager.Instance.level1Complete)
        {
            Destroy(gameObject, 0);
        }
    }
}
