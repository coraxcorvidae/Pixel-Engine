using System;
using System.Collections;
using System.Collections.Generic;
using PixelEngine.Extensions.XInput;

namespace PixelEngine
{
    public class Controllers : IEnumerable<Controller>
    {
        public static bool IsAvailable;

        private Game game;

        public Controller this[int index]
        {
            get => GamePads[index];
            set => GamePads[index] = value;
        }


        public Controllers(Game game)
        {
            this.game = game;
            IsAvailable = false;
            try
            {
                var test = new Extensions.XInput.Controller(UserIndex.One).IsConnected;
                IsAvailable = test;
            }
            catch
            {
                // No-Op
            }

            GamePads = new List<Controller>();
            for (var i = 0; i < 4; i++)
            {
                GamePads.Add(new Controller((GamePads) i));
            }
        }

        private List<Controller> GamePads { get; set; }

        public IEnumerator<Controller> GetEnumerator()
        {
            return ((IEnumerable<Controller>) GamePads).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Controller>) GamePads).GetEnumerator();
        }
    }
}