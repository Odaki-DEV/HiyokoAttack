using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    //移動スピード
    public float speed = 8f;
    //移動範囲の限界座標の絶対値
    public float moveableRange = 5.5f;
    //玉を打ち出す強さ
    public float power = 1000f;
    //打ち出すオブジェクトを格納
    public GameObject cannonBall;
    //弾を出現させる場所
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        //オブジェクト移動
        //押された矢印キーを取得し左右移動(左矢印キーで-1,右矢印キーで1が取得される.無入力は0)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);

        //移動範囲の制限
        //x軸の移動範囲を±moveableRange内に制限
        transform.position = new Vector2(Mathf.Clamp(
            transform.position.x, -moveableRange, moveableRange),
            transform.position.y);

        //スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        void Shoot()
        {
            //cannonBallobjectのインスタンス生成
            GameObject newBullet =
                Instantiate(cannonBall, spawnPoint.position,
                Quaternion.identity) as GameObject;
            
            //上方向にpower分だけ力を加える
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
        }
    }
}
