namespace AssetTool
{
    [JsonAsset("CommonUIInputData")]
    public class UCommonUIInputData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonUIHoldData")]
    public class UCommonUIHoldData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputBaseControllerData")]
    public class UCommonInputBaseControllerData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputPlatformSettings")]
    public class UCommonInputPlatformSettings : UPlatformSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}