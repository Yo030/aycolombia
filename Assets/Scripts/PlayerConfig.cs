using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
DeleteAll       Removes all keys and values from the preferences.Use with caution.
DeleteKey       Removes key and its corresponding value from the preferences.
GetFloat        Returns the value corresponding to key in the preference file if it exists.
GetInt          Returns the value corresponding to key in the preference file if it exists.
GetString       Returns the value corresponding to key in the preference file if it exists.
HasKey          Returns true if key exists in the preferences.
Save            Writes all modified preferences to disk.
SetFloat        Sets the value of the preference identified by key.
SetInt          Sets the value of the preference identified by key.
SetString       Sets the value of the preference identified by key
*/
public class PlayerConfig : MonoBehaviour
{
    private int contador;
    public static bool OpcionesDeDesarollador = true;

    void Start()
    {
        //PlayerPrefs.GetInt("Global", 0);


        contador = PlayerPrefs.GetInt("Global");
        if (contador <= 0)
        {
            PlayerPrefs.SetInt("Colecionable_1", 0);
            PlayerPrefs.SetInt("Colecionable_2", 0);
            PlayerPrefs.SetInt("Colecionable_3", 0);
            PlayerPrefs.SetInt("Colecionable_4", 0);
            PlayerPrefs.SetInt("Colecionable_5", 0);
            PlayerPrefs.SetInt("Colecionable_6", 0);
            PlayerPrefs.SetInt("Colecionable_7", 0);
            PlayerPrefs.SetInt("Colecionable_8", 0);
            PlayerPrefs.SetInt("Colecionable_9", 0);
            PlayerPrefs.SetInt("Colecionable_10", 0);
            PlayerPrefs.SetInt("Colecionable_11", 0);
            PlayerPrefs.SetInt("Colecionable_12", 0);

            PlayerPrefs.SetInt("Colecionable_1_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_2_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_3_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_4_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_5_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_6_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_7_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_8_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_9_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_10_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_11_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_12_BOOL", 0);

            PlayerPrefs.SetInt("Huachicol_Contador", 0);
            PlayerPrefs.SetInt("Peña_Contador", 0);
        }
        else
        {

        }

        /*
        PlayerPrefs.SetInt("Colecionable_1", 0);
        PlayerPrefs.SetInt("Colecionable_2", 0);
        PlayerPrefs.SetInt("Colecionable_3", 0);
        PlayerPrefs.SetInt("Colecionable_4", 0);
        PlayerPrefs.SetInt("Colecionable_5", 0);
        PlayerPrefs.SetInt("Colecionable_6", 0);
        PlayerPrefs.SetInt("Colecionable_7", 0);
        PlayerPrefs.SetInt("Colecionable_8", 0);
        PlayerPrefs.SetInt("Colecionable_9", 0);
        PlayerPrefs.SetInt("Colecionable_10", 0);
        PlayerPrefs.SetInt("Colecionable_11", 0);
        PlayerPrefs.SetInt("Colecionable_12", 0);

        PlayerPrefs.SetInt("Colecionable_1_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_2_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_3_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_4_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_5_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_6_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_7_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_8_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_9_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_10_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_11_BOOL", 0);
        PlayerPrefs.SetInt("Colecionable_12_BOOL", 0);
        */
    }

}
