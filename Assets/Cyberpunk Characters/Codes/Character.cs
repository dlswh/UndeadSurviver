using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static float Damage
    {
        get { return GameManager.instance.playerId == 0 ? 1.1f : 1f; } //ù��° �÷��̾�� ����� 1.1�� ����
    }
    public static float Speed
    {
        get { return GameManager.instance.playerId == 1? 1.2f : 1f; } //�ι�° �÷��̾�� ���ǵ� 1.1���
    }

    public static int Count
    {
        get { return GameManager.instance.playerId == 2 ? 1 : 0; }
    }

    /*
    public static float WeaponSpeed
    {
        get { return GameManager.instance.playerId == 2 ? 1.1f : 1f; } //����° �÷��̾�� ����� 1.1�� ����
    }
    public static float WeaponRate
    {
        get { return GameManager.instance.playerId == 2 ? 0.9f : 1f; } //����° �÷��̾�� ����� 1.1�� ����
    }*/
}
