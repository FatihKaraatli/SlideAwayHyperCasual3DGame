using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksAndTriggerInstantiate : MonoBehaviour
{
    public GameObject triggerBox;
    public GameObject[] blocks;
    public GameObject finishLine;
    int randomInt;
    int[] randomIntArray = new int[10];
    float triggerBoxPosition = 24f;
    float blockPosition = 12f;

    void Start()
    {
        //PlayerPrefs.SetInt("restart" , 0);
        if (PlayerPrefs.GetInt("restart") == 1)
        {
            if (PlayerPrefs.GetInt("level") == 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                Instantiate(blocks[PlayerPrefs.GetInt("level:0,object:0")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:0,object:0")].transform.position.x, blocks[PlayerPrefs.GetInt("level:0,object:0")].transform.position.y, blocks[PlayerPrefs.GetInt("level:0,object:0")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:0,object:1")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:0,object:1")].transform.position.x, blocks[PlayerPrefs.GetInt("level:0,object:1")].transform.position.y, blocks[PlayerPrefs.GetInt("level:0,object:1")].transform.position.z)));

                Instantiate(finishLine, new Vector3(0, 0, 48f), Quaternion.identity);
                PlayerPrefs.SetInt("restart", 0);
            }
            else if (PlayerPrefs.GetInt("level") == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                Instantiate(blocks[PlayerPrefs.GetInt("level:1,object:0")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:1,object:0")].transform.position.x, blocks[PlayerPrefs.GetInt("level:1,object:0")].transform.position.y, blocks[PlayerPrefs.GetInt("level:1,object:0")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:1,object:1")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:1,object:1")].transform.position.x, blocks[PlayerPrefs.GetInt("level:1,object:1")].transform.position.y, blocks[PlayerPrefs.GetInt("level:1,object:1")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:1,object:2")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:1,object:2")].transform.position.x, blocks[PlayerPrefs.GetInt("level:1,object:2")].transform.position.y, blocks[PlayerPrefs.GetInt("level:1,object:2")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:1,object:3")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:1,object:3")].transform.position.x, blocks[PlayerPrefs.GetInt("level:1,object:3")].transform.position.y, blocks[PlayerPrefs.GetInt("level:1,object:3")].transform.position.z)));

                Instantiate(finishLine, new Vector3(0, 0, 96f), Quaternion.identity);
                PlayerPrefs.SetInt("restart", 0);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:0")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:0")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:0")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:0")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:1")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:1")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:1")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:1")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:2")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:2")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:2")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:2")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:3")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:3")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:3")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:3")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:4")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:4")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:4")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:4")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:2,object:5")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:2,object:5")].transform.position.x, blocks[PlayerPrefs.GetInt("level:2,object:5")].transform.position.y, blocks[PlayerPrefs.GetInt("level:2,object:5")].transform.position.z)));

                Instantiate(finishLine, new Vector3(0, 0, 144f), Quaternion.identity);
                PlayerPrefs.SetInt("restart", 0);
            }
            else if (PlayerPrefs.GetInt("level") == 3)
            {
                for (int i = 0; i < 7; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:0")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:0")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:0")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:0")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:1")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:1")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:1")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:1")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:2")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:2")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:2")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:2")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:3")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:3")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:3")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:3")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:4")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:4")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:4")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:4")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:5")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:5")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:5")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:5")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:6")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:6")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:6")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:6")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:3,object:7")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:3,object:7")].transform.position.x, blocks[PlayerPrefs.GetInt("level:3,object:7")].transform.position.y, blocks[PlayerPrefs.GetInt("level:3,object:7")].transform.position.z)));

                Instantiate(finishLine, new Vector3(0, 0, 192f), Quaternion.identity);
                PlayerPrefs.SetInt("restart", 0);
            }
            else if (PlayerPrefs.GetInt("level") > 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:0")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:0")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:0")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:0")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:1")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:1")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:1")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:1")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:2")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:2")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:2")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:2")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:3")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:3")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:3")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:3")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:4")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:4")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:4")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:4")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:5")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:5")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:5")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:5")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:6")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:6")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:6")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:6")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:7")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:7")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:7")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:7")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:8")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:8")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:8")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:8")].transform.position.z)));
                blockPosition += 24;
                Instantiate(blocks[PlayerPrefs.GetInt("level:?,object:9")], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[PlayerPrefs.GetInt("level:?,object:9")].transform.position.x, blocks[PlayerPrefs.GetInt("level:?,object:9")].transform.position.y, blocks[PlayerPrefs.GetInt("level:?,object:9")].transform.position.z)));

                Instantiate(finishLine, new Vector3(0, 0, 240f), Quaternion.identity);
                PlayerPrefs.SetInt("restart", 0);
            }
        }
        else if (PlayerPrefs.GetInt("restart") == 0)
        {
            if (PlayerPrefs.GetInt("level") == 0)
            {
                randomIntArray = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    randomIntArray[i] = -1;
                }
                for (int i = 0; i < 1; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                for (int i = 0; i < 2; i++)
                {
                    randomInt = RandomNumber();
                    for (int j = 0; j < 2; j++)
                    {
                        if (randomInt == randomIntArray[j])
                        {
                            randomInt = RandomNumber();
                            j = 0;
                        }
                    }
                    randomIntArray[i] = randomInt;
                    Instantiate(blocks[randomInt], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[randomInt].transform.position.x, blocks[randomInt].transform.position.y, blocks[randomInt].transform.position.z)));
                    blockPosition += 24;
                }
                Instantiate(finishLine, new Vector3(0, 0, 48f), Quaternion.identity);
                PlayerPrefs.SetInt("level:0,object:0", randomIntArray[0]);
                PlayerPrefs.SetInt("level:0,object:1", randomIntArray[1]);
            }
            else if (PlayerPrefs.GetInt("level") == 1)
            {
                randomIntArray = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    randomIntArray[i] = -1;
                }
                for (int i = 0; i < 3; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                for (int i = 0; i < 4; i++)
                {
                    randomInt = RandomNumber();
                    for (int j = 0; j < 4; j++)
                    {
                        if (randomInt == randomIntArray[j])
                        {
                            randomInt = RandomNumber();
                            j = 0;
                        }
                    }
                    randomIntArray[i] = randomInt;
                    Instantiate(blocks[randomInt], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[randomInt].transform.position.x, blocks[randomInt].transform.position.y, blocks[randomInt].transform.position.z)));
                    blockPosition += 24;
                }
                Instantiate(finishLine, new Vector3(0, 0, 96f), Quaternion.identity);
                PlayerPrefs.SetInt("level:1,object:0", randomIntArray[0]);
                PlayerPrefs.SetInt("level:1,object:1", randomIntArray[1]);
                PlayerPrefs.SetInt("level:1,object:2", randomIntArray[2]);
                PlayerPrefs.SetInt("level:1,object:3", randomIntArray[3]);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                randomIntArray = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    randomIntArray[i] = -1;
                }
                for (int i = 0; i < 5; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                for (int i = 0; i < 6; i++)
                {
                    randomInt = RandomNumber();
                    for (int j = 0; j < 6; j++)
                    {
                        if (randomInt == randomIntArray[j])
                        {
                            randomInt = RandomNumber();
                            j = 0;
                        }
                    }
                    randomIntArray[i] = randomInt;
                    Instantiate(blocks[randomInt], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[randomInt].transform.position.x, blocks[randomInt].transform.position.y, blocks[randomInt].transform.position.z)));
                    blockPosition += 24;
                }
                Instantiate(finishLine, new Vector3(0, 0, 144f), Quaternion.identity);
                PlayerPrefs.SetInt("level:2,object:0", randomIntArray[0]);
                PlayerPrefs.SetInt("level:2,object:1", randomIntArray[1]);
                PlayerPrefs.SetInt("level:2,object:2", randomIntArray[2]);
                PlayerPrefs.SetInt("level:2,object:3", randomIntArray[3]);
                PlayerPrefs.SetInt("level:2,object:4", randomIntArray[4]);
                PlayerPrefs.SetInt("level:2,object:5", randomIntArray[5]);
            }
            else if (PlayerPrefs.GetInt("level") == 3)
            {
                randomIntArray = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    randomIntArray[i] = -1;
                }
                for (int i = 0; i < 7; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                for (int i = 0; i < 8; i++)
                {
                    randomInt = RandomNumber();
                    for (int j = 0; j < 8; j++)
                    {
                        if (randomInt == randomIntArray[j])
                        {
                            randomInt = RandomNumber();
                            j = 0;
                        }
                    }
                    randomIntArray[i] = randomInt;
                    Instantiate(blocks[randomInt], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[randomInt].transform.position.x, blocks[randomInt].transform.position.y, blocks[randomInt].transform.position.z)));
                    blockPosition += 24;
                }
                Instantiate(finishLine, new Vector3(0, 0, 192f), Quaternion.identity);
                PlayerPrefs.SetInt("level:3,object:0", randomIntArray[0]);
                PlayerPrefs.SetInt("level:3,object:1", randomIntArray[1]);
                PlayerPrefs.SetInt("level:3,object:2", randomIntArray[2]);
                PlayerPrefs.SetInt("level:3,object:3", randomIntArray[3]);
                PlayerPrefs.SetInt("level:3,object:4", randomIntArray[4]);
                PlayerPrefs.SetInt("level:3,object:5", randomIntArray[5]);
                PlayerPrefs.SetInt("level:3,object:6", randomIntArray[6]);
                PlayerPrefs.SetInt("level:3,object:7", randomIntArray[7]);
            }
            else if (PlayerPrefs.GetInt("level") > 3)
            {
                randomIntArray = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    randomIntArray[i] = -1;
                }
                for (int i = 0; i < 9; i++)
                {
                    Instantiate(triggerBox, new Vector3(0, 2.5f, triggerBoxPosition), Quaternion.identity);
                    triggerBoxPosition += 24;
                }
                for (int i = 0; i < 10; i++)
                {
                    randomInt = RandomNumber();
                    for (int j = 0; j < 10; j++)
                    {
                        if (randomInt == randomIntArray[j])
                        {
                            randomInt = RandomNumber();
                            j = 0;
                        }
                    }
                    randomIntArray[i] = randomInt;
                    Instantiate(blocks[randomInt], new Vector3(0, 0, blockPosition), Quaternion.Euler(new Vector3(blocks[randomInt].transform.position.x, blocks[randomInt].transform.position.y, blocks[randomInt].transform.position.z)));
                    blockPosition += 24;
                }
                Instantiate(finishLine, new Vector3(0, 0, 240f), Quaternion.identity);
                PlayerPrefs.SetInt("level:?,object:0", randomIntArray[0]);
                PlayerPrefs.SetInt("level:?,object:1", randomIntArray[1]);
                PlayerPrefs.SetInt("level:?,object:2", randomIntArray[2]);
                PlayerPrefs.SetInt("level:?,object:3", randomIntArray[3]);
                PlayerPrefs.SetInt("level:?,object:4", randomIntArray[4]);
                PlayerPrefs.SetInt("level:?,object:5", randomIntArray[5]);
                PlayerPrefs.SetInt("level:?,object:6", randomIntArray[6]);
                PlayerPrefs.SetInt("level:?,object:7", randomIntArray[7]);
                PlayerPrefs.SetInt("level:?,object:8", randomIntArray[8]);
                PlayerPrefs.SetInt("level:?,object:9", randomIntArray[9]);
            }
        }
    }

    

    public int RandomNumber()
    {
        randomInt = Random.Range(0, 40);
        return randomInt;
    }
}
