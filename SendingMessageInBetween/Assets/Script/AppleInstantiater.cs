using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Assertions;

public class AppleInstantiater : MonoBehaviour
{
    [SerializeField] private float instantiateInterval = 1f;
    [SerializeField] private GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstantiateApple), 1, instantiateInterval);
    }

    private void InstantiateApple(){
        Instantiate(apple, transform.position, transform.rotation);
    }

      void OnValidate(){
        Assert.IsNotNull(apple, $"{nameof(apple)} cannot be null in {name}");
         }
}
