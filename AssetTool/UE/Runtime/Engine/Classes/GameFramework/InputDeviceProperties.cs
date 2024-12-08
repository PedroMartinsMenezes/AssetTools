namespace AssetTool
{
    [JsonAsset("InputDeviceProperty")]
    public class UInputDeviceProperty : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorInputDeviceProperty")]
    public class UColorInputDeviceProperty : UInputDeviceProperty
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorInputDeviceCurveProperty")]
    public class UColorInputDeviceCurveProperty : UInputDeviceProperty
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputDeviceTriggerEffect")]
    public class UInputDeviceTriggerEffect : UInputDeviceProperty
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputDeviceTriggerFeedbackProperty")]
    public class UInputDeviceTriggerFeedbackProperty : UInputDeviceTriggerEffect
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputDeviceTriggerResistanceProperty")]
    public class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputDeviceTriggerVibrationProperty")]
    public class UInputDeviceTriggerVibrationProperty : UInputDeviceTriggerEffect
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputDeviceAudioBasedVibrationProperty")]
    public class UInputDeviceAudioBasedVibrationProperty : UInputDeviceProperty
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}