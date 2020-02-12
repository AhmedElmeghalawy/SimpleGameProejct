using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    public GameObject player;

    public GameObject tryAgainMenu;

    //يتم تنفيذ هذا الامر مرة واحده فى بداية تشغيل المشهد او اللعبة
    void Start() {
        tryAgainMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

        //Yاذا كان ال 
        //اقل من -10 
        //هذا معناه ان الشخصية سقطت
        if (player.transform.position.y <= -10) {
            //show the menu
            tryAgainMenu.gameObject.SetActive(true);
        }


    }


    public void ReloadLevel() {
        //Sceneاعاده تشغيل ال
        SceneManager.LoadScene(0);
    }




}
