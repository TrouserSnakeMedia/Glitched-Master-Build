using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {
    public static GameControl control;

    public float Health;
    public GameObject Player;

	void Awake ()
    {

        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this)
        {
            Destroy(gameObject);
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + Health);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("playerX", Player.transform.position.x);
        PlayerPrefs.SetFloat("playerY", Player.transform.position.y);
        PlayerPrefs.SetFloat("playerZ", Player.transform.position.z);

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.Health = Health;
        

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        Vector3 savedPosition = new Vector3(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"), PlayerPrefs.GetFloat("playerZ"));
        Player.transform.position = savedPosition;
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            Health = data.Health;
        }
    }
}

[Serializable]
class PlayerData
{
    public float Health;

}
