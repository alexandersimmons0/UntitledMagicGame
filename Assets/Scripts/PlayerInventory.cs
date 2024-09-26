using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInventory : MonoBehaviour{
    public class InventoryObject{
        public int objID;
        public int objCount;
        public string objName;        
    }
    int i;
    public List<InventoryObject> objects = new List<InventoryObject>();

    public void CollectObject(GameObject collectable){
        if(!objects.Any()){
            objects.Add(new InventoryObject() { objName = collectable.name, objCount = 1});
        }else if(!objects.Exists(x => x.objName == collectable.name)){
            objects.Add(new InventoryObject() { objName = collectable.name, objCount = 1});
        }else{
            //i = objects.IndexOf(new InventoryObject(){ objName = collectable.name });
            //objects[i].objCount += 1;
            var item = objects.FirstOrDefault(x => x.objName == collectable.name);
            if(item != null){
                item.objCount += 1;
            }
        }
    }

    public void DisplayInventory(){
        foreach(InventoryObject Aobject in objects){
            Debug.Log(Aobject.objName + " Amount of: " + Aobject.objCount);
        }
        
    }
    //maybe change return type?
    //what inputs and outputs
    //how store and track inventory objects
    public void AttemptCraft(){

    }
}
