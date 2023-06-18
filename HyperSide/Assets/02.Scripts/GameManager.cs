using UnityEngine;
using DG.Tweening;
using TMPro;

public class GameManager : MonoBehaviour
{
    public delegate void GameEndEventHandler(bool isVictory);
    public static GameEndEventHandler GameOver;

    [HideInInspector]
    public bool isPlaying = true;

    public Nexus allyNexus;
    public Nexus enemyNexus;

    public TextMeshProUGUI ally_hp;
    public TextMeshProUGUI enemy_hp;

    void Start()
    {
        Nexus.GameEnd += GameEnd;
    }

    void Update()
    {
        ally_hp.text = $"{(allyNexus.hp > 0 ? allyNexus.hp : 0)}";
        enemy_hp.text = $"{(enemyNexus.hp > 0 ? enemyNexus.hp : 0)}";
    }

    void GameEnd(bool isVictory)
    {
        isPlaying = false;
        /*
         * ����� ���� ������ �� ������ �ڵ� �ۼ��ϼ���
         * victory lose ��¼�� �װ�
         * DG.Tweening ����Ʈ �س����� ���ڰ� ������ ^^
         */

        if (isVictory)
        {
            //�̰��!!!
            //Debug.Log("victory!!");
        }
        else
        {
            //����...
            //Debug.Log("lose...");
        }
        GameOver(isVictory);
    }
}
