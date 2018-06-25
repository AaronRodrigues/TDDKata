using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDDKata.GameOfLife;

namespace TDDKata.Tests.GameOfLife
{
    [TestFixture]
    public class GameOfLifeTests
    {

        [Test]
        public void foo()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void AnyLiveCellWithFewerthanTwoLiveNeighborsDiesAsIfByUnderPopulation()
        {
            Cellstate currentState = Cellstate.Alive;
            int liveNeighbours = 1;
            Cellstate result = LifeRules.GetNewState(currentState, liveNeighbours);
            Assert.AreEqual(Cellstate.Dead, result);
        }


        [Test]
        public void LiveCell_TwoOrThreeLiveNeighbours_LivestoNextGeneration()
        {
            Cellstate currentState = Cellstate.Alive;
            int liveNeghbours = 3;
            Cellstate result = LifeRules.GetNewState(currentState, liveNeghbours);
            Assert.AreEqual(Cellstate.Alive, result);
        }

        [Test]
        public void LiveCell_MoreThanThreeLiveNeighbours_DiesByOverpopulation()
        {
            Cellstate currentState = Cellstate.Alive;
            int liveNeghbours = 4;
            Cellstate result = LifeRules.GetNewState(currentState, liveNeghbours);
            Assert.AreEqual(Cellstate.Dead, result);
        }

        [Test]
        public void DeadCell_ExactlyThreeLiveNeighbours_BecomesLiveByReproduction()
        {
            Cellstate currentState = Cellstate.Dead;
            int liveNeghbours = 3;
            Cellstate result = LifeRules.GetNewState(currentState, liveNeghbours);
            Assert.AreEqual(Cellstate.Alive, result);
        }
        //   Any live cell with fewer than two live neighbors dies, as if by under population.
        //   Any live cell with two or three live neighbors lives on to the next generation.
        //   Any live cell with more than three live neighbors dies, as if by overpopulation.
        //   Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
    }
}
