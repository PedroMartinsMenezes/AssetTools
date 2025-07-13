namespace AssetTool
{
    [JsonAsset("CascadeConfiguration")]
    public class UCascadeConfiguration : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}