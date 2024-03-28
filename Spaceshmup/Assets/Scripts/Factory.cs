using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory 
{
    private Database database;
    public Factory(Database database)
    {
        this.database = database;
    }

    public GameObject GetShuttle(EShuttleType eShuttleType){
        var shuttles = database.shuttleConfigs;
        foreach(var config in shuttles){
            if(config.shuttleType == eShuttleType){
                return AddPropertiesToShuttle(config);
            }
        }
        return null;
    }

    private GameObject AddPropertiesToShuttle(ShuttleConfig config)
    {
        GameObject shuttle = GameObject.Instantiate(config.prefab);
        SpaceShuttle spaceShuttle =  shuttle.AddComponent<SpaceShuttle>();
        spaceShuttle.factory = this;
        spaceShuttle.shuttleConfig = config;
        return shuttle;
    }

     public GameObject GetBullet(EBulletType eBulletType, Vector3 position, Quaternion rotation){
        var shuttles = database.bulletConfigs;
        //ToDo
        //Going through foreach everytime we need a bullet is not a good way
        //There is a  room for optimization
        foreach(var config in shuttles){
            if(config.bulletType == eBulletType){
                 GameObject bulletGO = GameObject.Instantiate(config.prefab, position, rotation);
                 Bullet bullet = bulletGO.AddComponent<Bullet>();
                bullet.bulletConfig = config;
                return bulletGO;
            }
        }
        return null;
    }
}
