using UnityEngine;
using UnityEngine.SceneManagement; // ���������� ����������� ������� ���������� �������

public class SceneChange : MonoBehaviour
{
    // ��� ����� ��� �������� (������ ���� � Build Settings)
    public string sceneName;

    // �������� �������� Collider - ������� ������� ���������� ��� ������
    void OnTriggerEnter(Collider other) // Collider
    {
        // �������� ����� ����� SceneManager (�������� � �����)
        SceneManager.LoadScene(sceneName);
    }
}