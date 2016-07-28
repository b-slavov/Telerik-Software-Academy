﻿namespace Santase.Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Santase.Logic;
    using Santase.Logic.Cards;
    using Santase.Logic.Players;
    using Santase.Logic.RoundStates;

    [TestClass]
    public class PlayerActionValidatorTests
    {
        private PlayerActionValidater validator = new PlayerActionValidater();

        [TestMethod]
        public void PlayingCardThatIsNotInHandShouldBeInvalid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Ace) };
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Club, CardType.Jack), Announce.None);
            var state = new FinalRoundState();
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            
            Assert.IsFalse(validator.IsValid(action, context, cards));
        }

        [TestMethod]
        public void PlayingCardFromHandShouldBeValid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Ace) };
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Club, CardType.Ace), Announce.None);
            var state = new FinalRoundState();
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            
            Assert.IsTrue(validator.IsValid(action, context, cards));
        }

        [TestMethod]
        public void PlayerChangesTrumpWithNineShouldBeValid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Nine) };
            var action = new PlayerAction(PlayerActionType.ChangeTrump, new Card(CardSuit.Club, CardType.Nine), Announce.None);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            
            Assert.IsTrue(validator.IsValid(action, context, cards));
        }

        [TestMethod]
        public void PlayerChangesTrumpWithQueenShouldBeInvalid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Queen) };
            var action = new PlayerAction(PlayerActionType.ChangeTrump, new Card(CardSuit.Club, CardType.Queen), Announce.None);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);

            Assert.IsFalse(validator.IsValid(action, context, cards));
        }

        [TestMethod]
        public void FourtyAnnounceShouldBeValid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Queen), new Card(CardSuit.Club, CardType.King) };
            var announce = Announce.Fourty;
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Club, CardType.Queen), announce);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            validator.IsValid(action, context, cards);

            Assert.AreEqual(Announce.Fourty, announce);
        }

        [TestMethod]
        public void FourtyAnnounceWithoutQueenOrKingShouldBeInvalid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Queen), new Card(CardSuit.Club, CardType.King), new Card(CardSuit.Heart, CardType.Jack) };
            var announce = Announce.Fourty;
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Heart, CardType.Jack), announce);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            validator.IsValid(action, context, cards);

            Assert.AreNotEqual(Announce.Fourty, action.Announce);
        }

        [TestMethod]
        public void FourtyAnnounceWhenPlayerIsNotFirstShouldChangeAnnounceToNone()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Queen), new Card(CardSuit.Club, CardType.King), new Card(CardSuit.Heart, CardType.Jack) };
            var announce = Announce.Fourty;
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Heart, CardType.Jack), announce);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.SecondPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            validator.IsValid(action, context, cards);

            Assert.AreEqual(Announce.None, action.Announce);
        }
    }
}
