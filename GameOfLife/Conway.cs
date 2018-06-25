namespace TDDKata.GameOfLife
{
    public enum Cellstate
    {
        Alive,
        Dead
    }

    public class LifeRules
    {
        public static Cellstate GetNewState(Cellstate currentState, int liveNeighbours)
        {
            if (currentState == Cellstate.Alive && liveNeighbours < 2)
            {
                currentState = Cellstate.Dead;
            }
            if (currentState == Cellstate.Alive && liveNeighbours > 3)
            {
                currentState = Cellstate.Dead;
            }
            if (currentState == Cellstate.Dead && liveNeighbours == 3)
            {
                currentState = Cellstate.Alive;
            }
            return currentState;
        }
    }

    
}