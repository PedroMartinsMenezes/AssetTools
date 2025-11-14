namespace AssetTool
{
    [JsonAsset("EngineCommand")]
    public class UEngineCommand : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}