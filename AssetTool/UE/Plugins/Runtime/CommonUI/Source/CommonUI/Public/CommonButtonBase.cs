namespace AssetTool
{
    [JsonAsset("CommonButtonStyle")]
    public class UCommonButtonStyle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonButtonBase")]
    public class UCommonButtonBase : UCommonUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WidgetLockedStateRegistration")]
    public class UWidgetLockedStateRegistration : UWidgetBinaryStateRegistration
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}