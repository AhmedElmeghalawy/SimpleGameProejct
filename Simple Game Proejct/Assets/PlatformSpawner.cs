using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    //(timer)
    //الوقت بين كل تنفيذ امر
    public float period = 2f;
    private float nextActionTime;




    // Start is called before the first frame update
    void Start() {
        nextActionTime = Time.time;
    }

    //every frame يتم تنفيذ هذا الامر  
    // Update is called once per frame
    void Update() {
        //timerتنفيذ الامر على حسب المتغرات تبع الـ

        if (Time.time > nextActionTime) {
            nextActionTime += period;

            CreateNewPlatform();//امر عمل المكعب
        }
    }


    void CreateNewPlatform() {
        //عمل مكعب عن طريق الكود
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //---------------------------------------------------------------------------------

        //عشوائية x ,Y وضع هذا المكعب فى احداثيات 
        cube.transform.position = new Vector3(Random.Range(0f, 3f), Random.Range(-2f, 2f), 0);


        //تغير مقياس او حجم المكعب 
        //الطول =  16
        //العرض  =   4
        //الارتفاع = 0.1
        cube.transform.localScale = new Vector3(4, 0.1f, 16);

        //---------------------------------------------------------------------------------

        //اعطاء رقم عشوائى من 1 الى 4
        // 1  or  2  or 3
        int randomNumber = Random.Range(1, 4);

        //لو الرقم كان 1
        if (randomNumber == 1) {
            //تغير لون المكعب الى اللون الاحمر
            cube.GetComponent<Renderer>().material.color = Color.red;
            //لو الرقم كان 2
        } else if (randomNumber == 2) {
            //تغير لون المكعب الى اللون الاخضر
            cube.GetComponent<Renderer>().material.color = Color.green;
            //لو الرقم كان 3
        } else if (randomNumber == 3) {
            //تغير لون المكعب الى اللون الاحمر
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }

        //---------------------------------------------------------------------------------

        //وضع الاسكريبت الخاص بتحريك المنصة فى المكعب
        PlatformController platformController = cube.AddComponent<PlatformController>();

        //تغير سرعة تحرك المنصة 
        platformController.platformSpeed = 0.2f;



    }




}
