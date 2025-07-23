using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
  [Header("버튼")]
  public Button playerKillButton;

  void Start()
  {
    if(playerKillButton != null) playerKillButton.onClick.AddListener(Die);
  }
    
  // 플레이어 사망 처리
  public void Die()
  {
    Debug.Log("[Player.cs] 플레이어가 사망했습니다.");
    GameEvents.TriggerPlayerDeath();  // 이벤트 발생
  }
}