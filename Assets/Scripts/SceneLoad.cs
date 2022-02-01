using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public GameObject loadingScreen; //Экран загрузки
    [SerializeField] private AssetReference scene; //Загружаемая сцена


    public void Load()
    {
        if (loadingScreen != null)
            loadingScreen.SetActive(true);
          
        scene.LoadSceneAsync(LoadSceneMode.Single);
    }
}
