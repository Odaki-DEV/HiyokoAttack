using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    //�ړ��X�s�[�h
    public float speed = 8f;
    //�ړ��͈͂̌��E���W�̐�Βl
    public float moveableRange = 5.5f;
    //�ʂ�ł��o������
    public float power = 1000f;
    //�ł��o���I�u�W�F�N�g���i�[
    public GameObject cannonBall;
    //�e���o��������ꏊ
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        //�I�u�W�F�N�g�ړ�
        //�����ꂽ���L�[���擾�����E�ړ�(�����L�[��-1,�E���L�[��1���擾�����.�����͂�0)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);

        //�ړ��͈͂̐���
        //x���̈ړ��͈͂��}moveableRange���ɐ���
        transform.position = new Vector2(Mathf.Clamp(
            transform.position.x, -moveableRange, moveableRange),
            transform.position.y);

        //�X�y�[�X�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        void Shoot()
        {
            //cannonBallobject�̃C���X�^���X����
            GameObject newBullet =
                Instantiate(cannonBall, spawnPoint.position,
                Quaternion.identity) as GameObject;
            
            //�������power�������͂�������
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
        }
    }
}
