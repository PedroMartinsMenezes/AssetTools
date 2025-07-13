namespace AssetTool
{
    [JsonAsset("ObjectTraceWorldSubsystem")]
    public class UObjectTraceWorldSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}