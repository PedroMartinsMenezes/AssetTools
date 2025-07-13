namespace AssetTool
{
    [JsonAsset("EngineCommand")]
    public class UEngineCommand : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}