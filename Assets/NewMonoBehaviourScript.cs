using UnityEngine;

public class SmartLevel : MonoBehaviour
{
    // ������Ѻ������ Inspector
    public int score;

    void Start()
    {
        // �� if / else ���дѺ������Ҵ
        if (score < 50)
        {
            Debug.Log("size 49");
        }
        else if (score >= 50 && score < 80)
        {
            Debug.Log("Size 56");
        }
        else
        {
            Debug.Log("SIZE 69");
        }
    }
}