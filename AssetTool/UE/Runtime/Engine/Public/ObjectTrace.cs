namespace AssetTool
{
    [JsonAsset("ObjectTraceWorldSubsystem")]
    public class UObjectTraceWorldSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}