using UnityEngine;

public class ReturnHomeState : State {
    private Vector3 destination;

    public ReturnHomeState(Character character) : base(character) {
    }

    public override void Tick() {
        character.MoveToward(destination);

        if (ReachedHome()) {
            Debug.Log("a");
            //character.SetState(new WanderState(character));
        }
    }

    public override void OnStateEnter() {
        character.GetComponent<Renderer>().material.color = Color.blue;
    }

    private bool ReachedHome() {
        return Vector3.Distance(character.transform.position, destination) < 0.5f;
    }
}