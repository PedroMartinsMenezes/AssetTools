namespace AssetTool
{
    [JsonAsset("CascadeOptions")]
    public class UCascadeOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}