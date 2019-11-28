using PixelEngine.Extensions.XInput;

namespace PixelEngine
{
    public class GamePad
    {
        public short LeftThumbDeadZone = 7849;
        public short RightThumbDeadZone = 8689;

        private readonly Gamepad State;
        public byte TriggerThreshold = 30;

        public GamePad()
        {
            PacketNumber = -1;
            State = new State().Gamepad;
        }

        internal GamePad(State state)
        {
            State = state.Gamepad;
            PacketNumber = state.PacketNumber;
        }

        public int PacketNumber { get; }
        public GamePadButtonFlags Buttons => (GamePadButtonFlags) State.Buttons;
        public bool None => (ushort) State.Buttons == 0;
        public bool DPadUp => ((ushort) State.Buttons & 1) == 1;
        public bool DPadDown => ((ushort) State.Buttons & 2) == 2;
        public bool DPadLeft => ((ushort) State.Buttons & 4) == 4;
        public bool DPadRight => ((ushort) State.Buttons & 8) == 8;
        public bool Start => ((ushort) State.Buttons & 16) == 16;
        public bool Back => ((ushort) State.Buttons & 32) == 32;
        public bool LeftThumb => ((ushort) State.Buttons & 64) == 64;
        public bool RightThumb => ((ushort) State.Buttons & 128) == 128;
        public bool LeftShoulder => ((ushort) State.Buttons & 256) == 256;
        public bool RightShoulder => ((ushort) State.Buttons & 512) == 512;
        public bool A => ((ushort) State.Buttons & 4096) == 4096;
        public bool B => ((ushort) State.Buttons & 8192) == 8192;
        public bool X => ((ushort) State.Buttons & 16384) == 16384;
        public bool Y => ((ushort) State.Buttons & 32768) == 32768;
        public float LeftTrigger => ApplyDeadZone(State.LeftTrigger, TriggerThreshold);
        public float RightTrigger => ApplyDeadZone(State.RightTrigger, TriggerThreshold);
        public float LeftThumbX => ApplyDeadZone(State.LeftThumbX, LeftThumbDeadZone);
        public float LeftThumbY => ApplyDeadZone(State.LeftThumbY, LeftThumbDeadZone);
        public float RightThumbX => ApplyDeadZone(State.RightThumbX, RightThumbDeadZone);
        public float RightThumbY => ApplyDeadZone(State.RightThumbY, RightThumbDeadZone);

        public override string ToString()
        {
            return
                $"Buttons: {State.Buttons}, LeftTrigger: {LeftTrigger}, "
                + $"RightTrigger: {RightTrigger}, LeftThumbX: {LeftThumbX}, "
                + $"LeftThumbY: {LeftThumbY}, RightThumbX: {RightThumbX}, "
                + $"RightThumbY: {RightThumbY}";
        }

        private float ApplyDeadZone(byte value, byte threshold)
        {
            if (threshold == 0)
                return value;

            if (value > threshold)
            {
                var maxValue = byte.MaxValue - threshold;
                value -= threshold;
                return value / (float) maxValue;
            }

            if (value <= -threshold)
            {
                var maxValue = byte.MaxValue - threshold;
                value += threshold;
                return value / (float) maxValue;
            }

            return 0;
        }

        private float ApplyDeadZone(short value, short threshold)
        {
            if (threshold == 0)
                return value;

            if (value > threshold)
            {
                var maxValue = short.MaxValue - threshold;
                value -= threshold;
                return value / (float) maxValue;
            }

            if (value <= -threshold)
            {
                var maxValue = short.MaxValue - threshold;
                value += threshold;
                return value / (float) maxValue;
            }

            return 0;
        }

        public void SetDeadZone(byte trigger, short leftStick, short rightStick)
        {
            TriggerThreshold = trigger;
            LeftThumbDeadZone = leftStick;
            RightThumbDeadZone = rightStick;
        }

        public void ResetDeadZone()
        {
            SetDeadZone(30, 7849, 8689);
        }

        public void RemoveDeadZone()
        {
            SetDeadZone(0, 0, 0);
        }
    }
}