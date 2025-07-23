using UnityEngine;

public class UIManager : MonoBehaviour
{
  // 이벤트 구독
  void OnEnable()
  {
    GameEvents.OnPlayerDeath += OnPlayerDeathUI;
  }
  
  // 이벤트 해지
  void OnDisable()
  {
    GameEvents.OnPlayerDeath -= OnPlayerDeathUI;
  }
  
  // 플레이어 사망 시 호출
  void OnPlayerDeathUI()
  {
    Debug.Log("[UIManager.cs] 게임 오버 UI 표시");
  }
}