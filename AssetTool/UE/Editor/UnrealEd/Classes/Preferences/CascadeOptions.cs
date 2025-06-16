namespace AssetTool
{
    [JsonAsset("CascadeOptions")]
    public class UCascadeOptions : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}