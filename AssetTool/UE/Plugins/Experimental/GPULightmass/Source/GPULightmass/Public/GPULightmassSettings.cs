namespace AssetTool
{
    [JsonAsset("GPULightmassSettings")]
    public class UGPULightmassSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GPULightmassSettingsActor")]
    public class AGPULightmassSettingsActor : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GPULightmassSubsystem")]
    public class UGPULightmassSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}