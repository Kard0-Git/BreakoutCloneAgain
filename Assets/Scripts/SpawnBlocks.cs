using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    public float rows;
    public float collums;

    public float spacingX;

    public float spacingY;


    public GameObject Block_prefab;

    public Transform Block_handler_transform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Block_Spawner();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawns the blocks that will be broken
    void Block_Spawner()
    {
        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j < collums; j++)
            {
                Vector2 new_pos = new Vector2(i + spacingX, j + spacingY);
                Instantiate(Block_prefab,new_pos,Quaternion.identity,Block_handler_transform.transform);
            }
        }
    }
}
