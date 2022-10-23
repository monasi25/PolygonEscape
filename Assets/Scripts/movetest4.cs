using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest4 : MonoBehaviour
{
    public AudioClip coinSE; //効果音系変数
    
    AudioSource aud;

    GameObject director;   //UI更新

    private CharacterController charaCon;
    private Animator animCon;  //  アニメーションするための変数
    private Vector3 moveDirection = Vector3.zero;   //  移動する方向とベクトルの変数（最初は初期化しておく）

    private float idoSpeed = 5.0f;         // 移動速度（Public＝インスペクタで調整可能）
    private float rotateSpeed = 3.0f;     // 向きを変える速度（Public＝インスペクタで調整可能）
    private float kaitenSpeed = 1200.0f;   // プレイヤーの回転速度（Public＝インスペクタで調整可能）
    private float gravity = 20.0f;   //重力の強さ（Public＝インスペクタで調整可能）
    private float jumpPower = 8.0f;

    public bool dash = false;
    // Start is called before the first frame update
    void Start()
    {
        charaCon = GetComponent<CharacterController>();
        animCon = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        director = GameObject.Find("Gamedirector");
    }

    // Update is called once per frame
    void Update()
    {
        var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;  //  カメラが追従するための動作
        Vector3 direction = cameraForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");  //  テンキーや3Dスティックの入力（GetAxis）があるとdirectionに値を返す
        
        charaCon.Move(moveDirection * Time.deltaTime);  //CharacterControllerの付いているこのオブジェクトを移動させる処理

        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)  //  テンキーや3Dスティックの入力（GetAxis）がゼロの時の動作
        {
            animCon.SetBool("walk", false);  //  Runモーションしない
           
        }

        else //  テンキーや3Dスティックの入力（GetAxis）がゼロではない時の動作
        {
            MukiWoKaeru(direction);  //  向きを変える動作の処理を実行する（後述）
            animCon.SetBool("walk", true);  //  Runモーションする
        }


        // ▼▼▼落下処理▼▼▼
        if (charaCon.isGrounded)    //CharacterControllerの付いているこのオブジェクトが接地している場合の処理
        {
            moveDirection.y = 0f;  //Y方向への速度をゼロにする
            if (Input.GetKey(KeyCode.LeftShift))
            {
                dash = true;
                idoSpeed = 9;
                animCon.SetBool("run", true);
            }
            if ((dash == true) && !(Input.GetKey(KeyCode.LeftShift)))
            {
                dash = false;
                idoSpeed = 5;
                animCon.SetBool("run", false);
            }
            


            moveDirection = direction * idoSpeed;  //移動スピードを向いている方向に与える

              //このスケール感のゲームにジャンプ機能載せるとマジで酔う
               
             if (Input.GetKeyDown("space") || Input.GetButtonDown("Jump")) //Spaceキーorジャンプボタンが押されている場合
            {
                moveDirection.y = jumpPower; //Y方向への速度に「ジャンプパワー」の変数を代入する
                animCon.SetBool("jump", true);
            }
            else //Spaceキーorジャンプボタンが押されていない場合
            {
                moveDirection.y -= gravity * Time.deltaTime; //マイナスのY方向（下向き）に重力を与える（これを入れるとなぜかジャンプが安定する…）
                animCon.SetBool("jump", false);

            }
            

        }
        else  //CharacterControllerの付いているこのオブジェクトが接地していない場合の処理
        {
            moveDirection.y -= gravity * Time.deltaTime;  //マイナスのY方向（下向き）に重力を与える
        }

        
    }
       void OnTriggerEnter(Collider other)
       {
          if(other.gameObject.tag == "star")
          {
            director.GetComponent<director>().starget();
            aud.PlayOneShot(coinSE);
            
            Destroy(other.gameObject);
            
          }
       }
    
    
    void MukiWoKaeru(Vector3 mukitaiHoukou)
    {
        Quaternion q = Quaternion.LookRotation(mukitaiHoukou);          // 向きたい方角をQuaternion型に直す
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, kaitenSpeed * Time.deltaTime);   // 向きを q に向けてじわ～っと変化させる.
    }
}
