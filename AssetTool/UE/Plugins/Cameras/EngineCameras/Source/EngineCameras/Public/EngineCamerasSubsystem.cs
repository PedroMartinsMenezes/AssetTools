namespace AssetTool
{
    [JsonAsset("EngineCamerasSubsystem")]
    public class UEngineCamerasSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}