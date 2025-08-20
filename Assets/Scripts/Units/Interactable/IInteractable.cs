namespace Juhyeon.Units
{
    public interface IInteractable : IUnit
    {
        void Interact(IAttackable target);
    }
}
