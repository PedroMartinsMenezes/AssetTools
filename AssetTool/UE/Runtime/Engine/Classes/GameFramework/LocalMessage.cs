namespace AssetTool
{
    [JsonAsset("LocalMessage")]
    public class ULocalMessage : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}