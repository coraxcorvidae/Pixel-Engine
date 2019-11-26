
using SharpDX.XInput;

namespace PixelEngine
{
    public class Controller
    {
        private readonly SharpDX.XInput.Controller controller;

        public GamePad State;
        public GamePads GamePads { get; private set; }

        private UserIndex UserIndex { get; set; }

        public bool IsConnected
        {
            get
            {
                if (!IsAvailable || GamePads == GamePads.None)
                    return false;

                try
                {
                    return controller.IsConnected;
                }
                catch
                {
                }

                return false;
            }
        }

        public bool IsAvailable { get; set; }

        public Controller(GamePads gamePads)
        {
            IsAvailable = false;
            if (gamePads != GamePads.None)
            {
                try
                {
                    var c = new SharpDX.XInput.Controller(gamePads.ToUserIndex());
                    var tmp = c.IsConnected;
                    if (c.IsConnected)
                    {
                        controller = c;
                        GamePads = gamePads;
                        UserIndex = gamePads.ToUserIndex();
                        IsAvailable = true;
                        SharpDX.XInput.Controller.SetReporting(true);
                        State = GetState();
                    }
                }
                catch
                {
                    // No-Op
                }
            }

            if (IsAvailable) return;

            controller = null;
            GamePads = GamePads.None;
            IsAvailable = false;
            State = new GamePad();
        }

        public BatteryInformation GetBatteryInformation(BatteryDeviceType batteryDeviceType)
        {
            if (!IsAvailable) return new BatteryInformation();
            try
            {
                return controller.GetBatteryInformation(batteryDeviceType);
            }
            catch
            {
                // No-Op
            }

            return new BatteryInformation();
        }

        public Capabilities GetCapabilities(DeviceQueryType deviceQueryType)
        {
            if (!IsAvailable) return new Capabilities();
            try
            {
                return controller.GetCapabilities(deviceQueryType);
            }
            catch
            {
                // No-Op
            }

            return new Capabilities();
        }

        public bool GetCapabilities(DeviceQueryType deviceQueryType, out Capabilities capabilities)
        {
            if (IsAvailable)
                try
                {
                    capabilities = controller.GetCapabilities(deviceQueryType);
                    return true;
                }
                catch
                {
                    // No-Op
                }

            capabilities = new Capabilities();
            return false;
        }

        public bool GetKeystroke(DeviceQueryType deviceQueryType, out Keystroke keystroke)
        {
            if (IsAvailable)
                try
                {
                    var result = controller.GetKeystroke(deviceQueryType, out keystroke);
                    if (result.Success)
                        return true;
                }
                catch
                {
                    // No-Op
                }

            keystroke = new Keystroke();
            return false;
        }

        public GamePad GetState()
        {
            GetState(out var state);
            return state;
        }

        public bool GetState(out GamePad state)
        {
            if (IsAvailable)
            {
                try
                {
                    state = new GamePad(controller.GetState());
                    State = state;
                    return true;
                }
                catch
                {
                    // No-Op
                }
            }

            state = new GamePad();
            State = state;
            return false;
        }

        public bool SetRumble(Rumble rumble)
        {
            if (IsAvailable)
                try
                {
                    controller.SetVibration(rumble.ToVibration());
                    return true;
                }
                catch
                {
                    // No-Op
                }

            return false;
        }

        public bool StopRumble()
        {
            if (IsAvailable)
                try
                {
                    controller.SetVibration(new Vibration {LeftMotorSpeed = 0, RightMotorSpeed = 0});
                    return true;
                }
                catch
                {
                    // No-Op
                }

            return false;
        }
    }
}