namespace AssetTool
{
    [JsonAsset("EngineMessage")]
    public class UEngineMessage : ULocalMessage
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}