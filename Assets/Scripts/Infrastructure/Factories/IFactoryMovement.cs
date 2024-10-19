using Core.Move;

namespace Infrastructure.Factories
{
    public interface IFactoryMovement
    {
        IMovement CreatMovement(IMovable movable);
        IRotation CreatRotation(IRotatable rotatable);
    }
}