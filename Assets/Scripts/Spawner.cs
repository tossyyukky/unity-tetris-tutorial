using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // �z��̍쐬�i��������u���b�N���ׂĂ��i�[����j
    [SerializeField]
    Block[] Blocks;


    // �֐��̍쐬

    // �����_���ȃu���b�N����I�Ԋ֐�
    Block GetRandomBlock()
    {
        int i = Random.Range(0, Blocks.Length);

        return Blocks[i] ? Blocks[i] : null;
    }

    // �I�΂ꂽ�u���b�N�𐶐�����֐�
    public Block SpawnBlock()
    {
        Block block = Instantiate(GetRandomBlock(), transform.position, Quaternion.identity);

        if (block)
        {
            return block;
        }
        return null;
    }
}
