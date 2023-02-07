using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    // These are case sensitive since they get converted to strings (of Scene names) before loading
    public enum Scene {
        MainMenuScene,
        LoadingScene,
        GameScene
    }

    private static Scene targetScene;

    public static void Load(Scene targetScene) {
        Loader.targetScene = targetScene;
        SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    public static void LoaderCallback() {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
