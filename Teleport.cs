// ��� ������ ���������� "����������" (������ ������� �������) �� Unity
using UnityEngine;                 // �������� ������� ������� (���������, ������ � �.�.)

// ��� ����� (������) ���������� Teleport. MonoBehaviour � ������ ��� ����� �������� �� ������ � Unity
public class Teleport : MonoBehaviour
{
    // ��� ��������� ���������� � � ����� ������ ����� � Unity!
    // ����� �������� �����, ���� �� ������������� ������
    public Transform teleportPoint;

    // ���� ����� �����������, ����� ������ ������ ������ � ���� ��������
    void OnTriggerEnter(Collider other)
    {
        // ���� ������� (����������) ��������� (teleportPoint) 
        // � ���������� �� �� ������, ������� ����� � ������� (other)
        other.transform.position = teleportPoint.position;
    }
}
