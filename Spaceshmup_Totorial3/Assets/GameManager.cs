using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Database database;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject button;
    [SerializeField] private DynamicBottonLoader dynamicBottonLoader;
    private Factory factory;
    // Start is called before the first frame update
    void Start()
    {
        factory = new Factory(database);
        dynamicBottonLoader.LoadButtonDynamic(database.shuttleConfigs, button, this);
    }

    // Update is called once per frame
  public void SelectShuttle(EShuttleType eShuttleType){
    UI.SetActive(false);
    factory.GetShuttle(eShuttleType);
  }
}
