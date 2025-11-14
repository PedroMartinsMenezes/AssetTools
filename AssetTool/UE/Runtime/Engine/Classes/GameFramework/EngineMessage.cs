namespace AssetTool
{
    [JsonAsset("EngineMessage")]
    public class UEngineMessage : ULocalMessage
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}