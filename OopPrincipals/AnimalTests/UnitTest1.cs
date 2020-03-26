using OopPrincipals.Classes;
using System;
using Xunit;

namespace AnimalTests
{
    public class UnitTest1
    {
        [Fact]
        public void HippoIsAbleToHoldBreath() //inherited from mammal class
        {
            Hippo hippo = new Hippo();
            string hold = hippo.CanHoldBreath();
            string expected = "I can hold my breath for what seems like forever!";
            Assert.Equal(expected, hold);
        }

        [Fact]
        public void HippoCanHoldBreathForFiveMinutes() //inherited from aquatic class
        {
            Hippo hippo = new Hippo();
            int hold = hippo.HoldBreathAmount;
            Assert.Equal(5, hold);
        }

        [Fact]
        public void DolphinCanMakeNoise() //inherited from animal class
        {
            Dolphins dolphins = new Dolphins();
            string gulb = dolphins.Sound();
            Assert.Equal("I make a GLUB GLUB GLUB sound in the water.", gulb);
        }

        [Fact]
        public void DolphinsHaveLiveBirths() //inherited from mammal class
        {
            Dolphins dolphins = new Dolphins();
            string birth = dolphins.Birth;
            Assert.Equal("live birth", birth);
        }

        [Fact]
        public void LionCanHunt() //inherited from land class
        {
            Lion lion = new Lion();
            string hunt = lion.Hunt();
            Assert.Equal("I hunt for animals smaller than me!", hunt);
        }

        [Fact]
        public void LionLiveInPacks() //inherited from Mammal class
        {
            Lion lion = new Lion();
            string packs = lion.LivesInPack;
            Assert.Equal("I live with my buddies", packs);
        }

        [Fact]
        public void WolvesCanRun() // inherited from animal class
        {
            Wolves wolfie = new Wolves();
            bool hurry = wolfie.CanRun();
            Assert.True(hurry);
        }
        [Fact]

        public void WolvesHaveWarmBlood() // inherited from Mammal class
        {
            Wolves wolfie = new Wolves();
            string blood = wolfie.Blood;
            Assert.Equal("warm blooded", blood);
        }

        [Fact]
        public void SnakesHaveColdBlood() // inherited from Reptile class
        {
            Snake snake = new Snake();
            string blood = snake.Blood;
            Assert.Equal("Cold-blooded", blood);
        }

        [Fact]
        public void SnakesHaveScales() // inherited from Reptile class
        {
            Snake snake = new Snake();
            bool scales = snake.HasScales;
            Assert.True(scales);
        }

        [Fact]
        public void TurtlesLayEggs()// inherited from Reptile class
        {
            Turtle turtie = new Turtle();
            string eggs = turtie.Birth;
            Assert.Equal("eggs", eggs);
        }

        [Fact]
        public void TurtlesCanSnap()// inherited from Reptile class
        {
            Turtle turtie = new Turtle();
            bool ohSnap = turtie.CanSnapAtYou();
            Assert.True(ohSnap);
        }


        [Fact]
        public void SnakeCanDoMethodFromInterface() // from interface
        {
            Snake snake = new Snake();
            string wiggle = snake.WiggleBody();
            string expected = "Though I have no limps, I am full capable swimming! Wiggling this body is life.";
            Assert.Equal(expected, wiggle);
        }

        [Fact]
        public void TurtieCanStalkFromAttackInterface()
        {
            Turtle turtie = new Turtle();
            string strawberries = turtie.StalkPrey();
            Assert.Equal("This strawberry doesn't know what's comin... hehe.", strawberries);
        }

        [Fact]

        public void WolvesCanChaseFromAttackInterface()
        {
            Wolves wolfie = new Wolves();
            string attack = wolfie.ChasePrey();
            Assert.Equal("Since I live with my buddies, we all will chase this bunny together! RUN GUYS RUN!", attack);

        }

        [Fact]

        public void HippoCanLeapFromAttackInterface()
        {
            Hippo hippo = new Hippo();
            string leap = hippo.LeapAtPrey();
            Assert.Equal("My weight will literally end you.", leap);
        }

        [Fact]

        public void WolvesHaveSharpTeethAttackInterface()
        {
            Wolves wolfie = new Wolves();
            string attack = wolfie.SharpTeeth;
            Assert.Equal("I have razor sharp teeth!", attack);
        }
        
        [Fact]
        public void SnakeCanFloatSwimInterface()
        {
            Snake snakey = new Snake();
            string floats = snakey.Float();
            Assert.Equal("As long as I wiggle, I will float.", floats);
        }

        [Fact]
        public void DolphinCantRunOverridesVirtual()
        {
            Dolphins dolphins = new Dolphins();
            bool cannot = dolphins.CanRun();
            Assert.False(cannot);
        }

        [Fact]
        public void DolphinHasNoLegsOverridesVirtual()
        {
            Dolphins dolphins = new Dolphins();
            bool cannot = dolphins.HasLegs;
            Assert.False(cannot); 
        }

        [Fact]
        public void SnakeHasNoLegsOverridesVirtual()
        {
            Snake snake = new Snake();
            bool cannot = snake.HasLegs;
            Assert.False(cannot);
        }

        [Fact]
        public void SnakeIsAnAnimal()
        {
            Snake snakey = new Snake();

            bool snake;
            if (snakey is Animal)
            {
                snake = true;
            }
            else
            {
                snake = false;
            }

            Assert.True(snake);
            
        }

    }
}
