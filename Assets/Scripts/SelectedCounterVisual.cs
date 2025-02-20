using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour {

    private void Start() {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e) {
        throw new System.NotImplementedException();
    }

}
