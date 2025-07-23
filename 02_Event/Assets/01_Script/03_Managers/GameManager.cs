using UnityEngine;

public class GameManager : MonoBehaviour
{
  // 이벤트 구독
  void OnEnable()
  {
    GameEvents.OnPlayerDeath += OnPlayerDeathLogic;
  }
  
  // 이벤트 해지
  void OnDisable()
  {
    GameEvents.OnPlayerDeath -= OnPlayerDeathLogic;
  }
  
  // 플레이어 사망 시 호출
  void OnPlayerDeathLogic()
  {
    Debug.Log("[GameManager.cs] 게임 정지 처리");
  }
}