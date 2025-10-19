using UnityEngine;

public class SmartLevel : MonoBehaviour
{
    // ทำให้ปรับค่าได้ใน Inspector
    public int score;

    void Start()
    {
        // ใช้ if / else แบ่งระดับความฉลาด
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