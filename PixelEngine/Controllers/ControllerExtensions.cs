﻿using System;
using SharpDX.XInput;

namespace PixelEngine
{
    /// <summary>
    /// Controller state helper class.
    /// </summary>
    internal static class ControllerExtensions
    {
        /// <summary>
        /// Convert a SharpDX UserInput
        /// </summary>
        /// <param name="gamePads"></param>
        /// <returns></returns>
        internal static UserIndex ToUserIndex(this GamePads gamePads)
        {
            switch (gamePads)
            {
                case GamePads.One:
                    return UserIndex.One;
                case GamePads.Two:
                    return UserIndex.Two;
                case GamePads.Three:
                    return UserIndex.Three;
                case GamePads.Four:
                    return UserIndex.Four;
                //case GamePads.None:
                //    break;
                case GamePads.Any:
                    return UserIndex.Any;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gamePads), gamePads, null);
            }
        }

        internal static Vibration ToVibration(this Rumble rumble) => new Vibration
        {
            LeftMotorSpeed = (ushort) (65535f * rumble.LeftMotorSpeed),
            RightMotorSpeed = (ushort) (65535f * rumble.RightMotorSpeed),
        };

        internal static GamePad ToGamePad(this State state)
        {
            return new GamePad(state);
        }
    }
}