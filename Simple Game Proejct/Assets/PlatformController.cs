using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    //سرعة تحرك المنصة
    public float platformSpeed = 0f;



    //يتم تنفيذ هذا الامر مرة واحده فى بداية تشغيل المشهد او اللعبة
    void Start() {
        //مسح المنصة بعد 2.5 ثوانى
        Destroy(this.gameObject, 2.5f);
    }

    //every frame يتم تنفيذ هذا الامر  
    // Update is called once per frame
    void Update() {
        Vector3 position = this.transform.position;
        position.z += platformSpeed;
        this.transform.position = position;
    }

}
