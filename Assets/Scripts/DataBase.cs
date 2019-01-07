using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Esta script, hace que se genere un nuevo menu en el unity, para asi crear una base de datos
 * facil para el programador. Aun estoy aprediendo de ella por lo que no puedo explicarla bien.
 * igual no hay mucho que explicar
 *  https://youtu.be/7If0gKu4H9c
 *  de aqui saque el codigo
 *  
*/
[CreateAssetMenu(menuName = "Items DB")]
public class Database : ScriptableObject {
    public List<Item> items = new List<Item>();

    public Item FindItemInDatabase(int id)
    {
        foreach (Item item in items)
        {
            if (item.id == id)
            {
                return item;
            }

        }
        return null;
    }
}

[System.Serializable]
public class Item
{
    public int id;
    public string name;
    public string description;
    public int cost;
    public int sellCost;
    public int useLevel;
    public Stats stats;

    [System.Serializable]
    public struct Stats
    {
        public int damage;
        public int defense;
        public float poder;
    }



}
    

[CreateAssetMenu(menuName = "Habilidades DB")]
public class DatabaseHabilidad : ScriptableObject
{ 

    public List<Habilidad> habilidades = new List<Habilidad>();

    public Habilidad FindHabilidadInDatabase(int id)
    {
        foreach (Habilidad habilidad in habilidades)
        {
            if (habilidad.id == id)
            {
                return habilidad;
            }

        }
        return null;
    }
}


[System.Serializable]
public class Habilidad
{
    public int id;
    public string name;
    public string description;
    public int cost;
    public int Cooldown;
    public int useLevel;
    public Stats stats;

    [System.Serializable]
    public struct Stats
    {
        public int damage;
        public int defense;
        public float poder;
    }
}
    