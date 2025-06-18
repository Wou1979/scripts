using UnityEngine;                                                          //1//    - ����������� ������������ ���� Unity, ����������� ��� ������ � MonoBehaviour � ������� Unity-��������.

public class SpeedTrigger : MonoBehaviour                                   //2//    - ���������� ������ SpeedTrigger, ������� ����������� �� MonoBehaviour (������� ����� ��� ���� �������� Unity).
{
    public float speedFactor = 3f;                                        //2.1//  - ���������� ���������(����� ������ � inspector) ���������� speedFactor ���� float �� ��������� 2.5 �� ���������.
    void OnTriggerEnter(Collider other)                                     //2.1m// - �����, ������������� ���������� Unity ��� ����� ������� ���������� � �������.
    {
        // �������� ��������� FirstPersonMovement � �������, ��������� � �������,
        // � ����������� ��� �������� ���� � speedFactor ���
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;  //2.1m.1// - ���������� �������� ���� ������.
    }

    void OnTriggerExit(Collider other)                                      //2.2m// - �����, ������������� ���������� Unity ��� ������ ������� ���������� �� ��������
    {
        // �������� ��������� FirstPersonMovement � �������, ��������� �� ��������,
        // � ���������� ��� �������� ���� � ��������� �������� (����� �� speedFactor)
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;  //2.2m.1// - ���������� �������� ���� ������.
    }
}