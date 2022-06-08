using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //�G�v���n�u
    public GameObject enemyPrefab;
    //���ԊԊu�̍ŏ�
    public float minTime = 2f;
    //���ԊԊu�̍ő�
    public float maxTime = 5f;
    //X���W�̍ŏ��l
    public float xMinPosition = -10f;
    //X���W�̍ő�l
    public float xMaxPosition = 10f;
    //Y���W�̍ŏ��l
    public float yMinPosition = 0f;
    //Y���W�̍ő�l
    public float yMaxPosition = 10f;
    //Z���W�̍ŏ��l
    public float zMinPosition = 10f;
    //Z���W�̍ő�l
    public float zMaxPosition = 20f;
    //�G�������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
        interval = GetRandamTime();
    }

    // Update is called once per frame
    void Update()
    {
        //
        time += Time.deltaTime;

        //
        if (time > interval)
        {
            //ememy���C���X�^���X������i��������j
            GameObject enemy = Instantiate(enemyPrefab);
            //���������G�̍��W�����肷��iGetRandomPosition�̈ʒu�ɏo�́j
            enemy.transform.position = GetRandomPosition();
            //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
            //���ɔ������鎞�ԊԊu�����肷��
            interval = GetRandamTime();
        }
    }

    //
    private float GetRandamTime()
    {
        return Random.Range(minTime, maxTime);
    }
    //�����_���Ȉʒu�𐶐�����֐�
    private Vector3 GetRandomPosition()
    {
        //���ꂼ��̍��W�������_���ɐ�������
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3�^��Position��Ԃ�
        return new Vector3(x, y, z);
    }
}
