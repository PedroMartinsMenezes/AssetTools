namespace AssetTool
{
    [JsonAsset("AvaMaskMaterialInstanceProvider")]
    public class UAvaMaskMaterialInstanceProvider : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskMaterialInstanceWorldSubsystem")]
    public class UAvaMaskMaterialInstanceWorldSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskMaterialInstanceSubsystem")]
    public class UAvaMaskMaterialInstanceSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}