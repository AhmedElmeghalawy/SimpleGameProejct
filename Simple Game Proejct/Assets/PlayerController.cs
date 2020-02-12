using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    private GameObject player;//اللاعب او الشخصية المراد تحريكها
    public float playerSpeed = 0.1f;//(سرعة الاعب)

    public float jumpAmount = 8f;//(مقدار وثب او قفز الشخصية )

    private bool isGrounded = false;


    //يتم تنفيذ هذا الامر مرة واحده فى بداية تشغيل المشهد او اللعبة
    // Start is called before the first frame update
    void Start() {
        player = this.gameObject;

    }

    //every frame يتم تنفيذ هذا الامر  
    // Update is called once per frame
    void Update() {
        PlayerControls();
    }

    //امر تحكم الشخصية او اللاعب
    void PlayerControls() {

        Vector3 position = this.transform.position;

        //RightArrow الضغط على الزر الايمن الـ
        //or "D" key
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            position.x -= playerSpeed;
        }


        //LeftArrow الضغط على الزر الايسر الـ
        //or "A" key
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            position.x += playerSpeed;
        }

        this.transform.position = position;

        //---------------------------------------------------------------------------------

        //spaceعند الضغط على مفتاح الـ
        if (Input.GetKeyDown(KeyCode.Space)) {
            //check for ground(collider)
            if (isGrounded) {

                //JumpAmpountتغير سرعة الجسم او الشخصية الى مقدار القفزالـ
                // فقط Yيتم تغير السرعة فى 
                GetComponent<Rigidbody>().velocity = new Vector3(0f, jumpAmount, 0f);

            }

        }

    }

    //ملامس للشخصية او اللاعب collider اذا كان هناك شىء او جسم 
    //و فى هذا المثال يكون هو المنصة
    void OnCollisionStay(Collision collisionInfo) {
        isGrounded = true;
    }


    // collider اذا تم ترك هذا الجسم الـ
    //و فى هذا المثال يكون هو المنصة
    void OnCollisionExit(Collision collisionInfo) {
        isGrounded = false;
    }

}
