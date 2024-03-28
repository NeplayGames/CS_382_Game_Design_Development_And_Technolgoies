using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicBottonLoader : MonoBehaviour
{
    public void LoadButtonDynamic(List<ShuttleConfig> shuttleConfigs, GameObject buttonGO, GameManager gameManager){
        foreach(var config in shuttleConfigs){
            Image image =  Instantiate(buttonGO,this.transform).GetComponent<Image>();
            image.sprite = config.icon;
            Button button = image.GetComponent<Button>();
            //ToDo:
            //We need to remove the listener 
            button.onClick.AddListener(() => gameManager.SelectShuttle(config.shuttleType));
        }
    }
}
