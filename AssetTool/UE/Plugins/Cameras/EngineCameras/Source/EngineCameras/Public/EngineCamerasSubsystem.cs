namespace AssetTool
{
    [JsonAsset("EngineCamerasSubsystem")]
    public class UEngineCamerasSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}