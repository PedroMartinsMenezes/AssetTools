namespace AssetTool
{
    [JsonAsset("WidgetBinaryStateRegistration")]
    public class UWidgetBinaryStateRegistration : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetHoveredStateRegistration")]
    public class UWidgetHoveredStateRegistration : UWidgetBinaryStateRegistration
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetPressedStateRegistration")]
    public class UWidgetPressedStateRegistration : UWidgetBinaryStateRegistration
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetDisabledStateRegistration")]
    public class UWidgetDisabledStateRegistration : UWidgetBinaryStateRegistration
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetSelectedStateRegistration")]
    public class UWidgetSelectedStateRegistration : UWidgetBinaryStateRegistration
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetEnumStateRegistration")]
    public class UWidgetEnumStateRegistration : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}