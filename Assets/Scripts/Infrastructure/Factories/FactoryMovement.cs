using Core.Move;
using Infrastructure.Services.Time;

namespace Infrastructure.Factories
{
    public class FactoryMovement : IFactoryMovement
    {
        private ITimeService _timeService;

        public IMovement CreatMovement(IMovable movable) => 
            new Movement(movable, _timeService);

        public IRotation CreatRotation(IRotatable rotatable) => 
            new Rotation(rotatable, _timeService);
    }
}