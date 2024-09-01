public interface IState
{
    void Tick();
    void PhysicsTick();
    void OnEnter();
    void OnExit();
}
