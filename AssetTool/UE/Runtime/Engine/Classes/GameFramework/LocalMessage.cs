namespace AssetTool
{
    [JsonAsset("LocalMessage")]
    public class ULocalMessage : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}