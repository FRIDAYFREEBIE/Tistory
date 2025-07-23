using System;

public static class GameEvents
{
  // 플레이어 사망 이벤트
  public static event Action OnPlayerDeath;
  
  // 이벤트 실행
  public static void TriggerPlayerDeath()
  {
    OnPlayerDeath?.Invoke();
  }
}