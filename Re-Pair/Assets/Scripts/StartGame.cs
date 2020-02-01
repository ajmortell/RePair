using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public void OnBtnPress() {
        GameStateMaster.Instance.ChangeState(2);
    }
}