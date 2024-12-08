namespace AssetTool
{
    [JsonAsset("LocalMessage")]
    public class ULocalMessage : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}