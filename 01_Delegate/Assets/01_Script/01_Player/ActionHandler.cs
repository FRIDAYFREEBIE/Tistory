using UnityEngine;
using UnityEngine.UI;

public class ActionHandler : MonoBehaviour
{
  [Header("버튼")]
  public Button actionButton;
  public Button attackButton;
  public Button skillButton;

  // 델리게이트 정의
  public delegate void ActionDelegate();
  public ActionDelegate currentAction;

  void Start()
  {
    // 기본 행동은 Attack
    currentAction = Attack;

    // 버튼 클릭 시 현재 행동 실행
    actionButton.onClick.AddListener(() => { currentAction?.Invoke(); });

    // 모드 전환 버튼
    attackButton.onClick.AddListener(() => SetToAttack());
    skillButton.onClick.AddListener(() => SetToSkill());
  }

  public void Attack()
  {
    Debug.Log("일반 공격");
  }

  public void UseSkill()
  {
    Debug.Log("스킬 사용");
  }

  public void SetToAttack()
  {
    currentAction = Attack;
    Debug.Log("공격 모드로 전환");
  }

  public void SetToSkill()
  {
    currentAction = UseSkill;
    Debug.Log("스킬 모드로 전환");
  }
}
