// SPDX-License-Identifier: MIT

using System;
using System.Runtime.InteropServices;

namespace SDL.Events
{
    [StructLayout(LayoutKind.Explicit)]
    public struct EventArgs : IEquatable<EventArgs>
    {
        public EventType Type => _type;
        [FieldOffset(0)]
        private readonly EventType _type;

        public CommonEventArgs CommonEventArgs => _commonEventArgs;
        [FieldOffset(0)]
        private readonly CommonEventArgs _commonEventArgs;

        public DisplayEventArgs DisplayEventArgs => _displayEventArgs;
        [FieldOffset(0)]
        private readonly DisplayEventArgs _displayEventArgs;

        public WindowEventArgs WindowEventArgs => _windowEventArgs;
        [FieldOffset(0)]
        private readonly WindowEventArgs _windowEventArgs;

        public KeyboardEventArgs KeyboardEventArgs => _keyboardEventArgs;
        [FieldOffset(0)]
        private readonly KeyboardEventArgs _keyboardEventArgs;

        public TextEditingEventArgs TextEditingEventArgs => _textEditingEventArgs;
        [FieldOffset(0)]
        private readonly TextEditingEventArgs _textEditingEventArgs;

        public TextInputEventArgs TextInputEventArgs => _textInputEventArgs;
        [FieldOffset(0)]
        private readonly TextInputEventArgs _textInputEventArgs;

        public MouseMotionEventArgs MouseMotionEventArgs => _mouseMotionEventArgs;
        [FieldOffset(0)]
        private readonly MouseMotionEventArgs _mouseMotionEventArgs;

        public MouseButtonEventArgs MouseButtonEventArgs => _mouseButtonEventArgs;
        [FieldOffset(0)]
        private readonly MouseButtonEventArgs _mouseButtonEventArgs;

        public MouseWheelEventArgs MouseWheelEventArgs => _mouseWheelEventArgs;
        [FieldOffset(0)]
        private readonly MouseWheelEventArgs _mouseWheelEventArgs;

        public JoystickAxisEventArgs JoystickAxisEventArgs => _joystickAxisEventArgs;
        [FieldOffset(0)]
        private readonly JoystickAxisEventArgs _joystickAxisEventArgs;

        public JoystickBallEventArgs JoystickBallEventArgs => _joystickBallEventArgs;
        [FieldOffset(0)]
        private readonly JoystickBallEventArgs _joystickBallEventArgs;

        public JoystickHatEventArgs JoystickHatEventArgs => _joystickHatEventArgs;
        [FieldOffset(0)]
        private readonly JoystickHatEventArgs _joystickHatEventArgs;

        public JoystickButtonEventArgs JoystickButtonEventArgs => _joystickButtonEventArgs;
        [FieldOffset(0)]
        private readonly JoystickButtonEventArgs _joystickButtonEventArgs;

        public JoystickDeviceEventArgs JoystickDeviceEventArgs => _joystickDeviceEventArgs;
        [FieldOffset(0)]
        private readonly JoystickDeviceEventArgs _joystickDeviceEventArgs;

        public ControllerAxisEventArgs ControllerAxisEventArgs => _controllerAxisEventArgs;
        [FieldOffset(0)]
        private readonly ControllerAxisEventArgs _controllerAxisEventArgs;

        public ControllerButtonEventArgs ControllerButtonEventArgs => _controllerButtonEventArgs;
        [FieldOffset(0)]
        private readonly ControllerButtonEventArgs _controllerButtonEventArgs;

        public ControllerDeviceEventArgs ControllerDeviceEventArgs => _controllerDeviceEventArgs;
        [FieldOffset(0)]
        private readonly ControllerDeviceEventArgs _controllerDeviceEventArgs;

        public AudioDeviceEventArgs AudioDeviceEventArgs => _audioDeviceEventArgs;
        [FieldOffset(0)]
        private readonly AudioDeviceEventArgs _audioDeviceEventArgs;

        public SensorEventArgs SensorEventArgs => _sensorEventArgs;
        [FieldOffset(0)]
        private readonly SensorEventArgs _sensorEventArgs;

        public QuitEventArgs QuitEventArgs => _quitEventArgs;
        [FieldOffset(0)]
        private readonly QuitEventArgs _quitEventArgs;

        public UserEventArgs UserEventArgs => _userEventArgs;
        [FieldOffset(0)]
        private readonly UserEventArgs _userEventArgs;

        public SystemWindowManagerEventArgs SystemWindowManagerEventArgs => _systemWindowManagerEventArgs;
        [FieldOffset(0)]
        private readonly SystemWindowManagerEventArgs _systemWindowManagerEventArgs;

        public TouchFingerEventArgs TouchFingerEventArgs => _touchFingerEventArgs;
        [FieldOffset(0)]
        private readonly TouchFingerEventArgs _touchFingerEventArgs;

        public MultiGestureEventArgs MultiGestureEventArgs => _multiGestureEventArgs;
        [FieldOffset(0)]
        private readonly MultiGestureEventArgs _multiGestureEventArgs;

        public DollarGestureEventArgs DollarGestureEventArgs => _dollarGestureEventArgs;
        [FieldOffset(0)]
        private readonly DollarGestureEventArgs _dollarGestureEventArgs;

        public DropEventArgs DropEventArgs => _dropEventArgs;
        [FieldOffset(0)]
        private readonly DropEventArgs _dropEventArgs;

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is EventArgs args && Equals(args);
        }

        public bool Equals(EventArgs other)
        {
            return
                _type == other._type &&
                _commonEventArgs.Equals(other._commonEventArgs);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_type, _commonEventArgs);
        }

        public static bool operator ==(EventArgs left, EventArgs right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(EventArgs left, EventArgs right)
        {
            return !(left == right);
        }

        #endregion IEquatable
    }
}
