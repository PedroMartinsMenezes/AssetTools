namespace AssetTool
{
    [JsonAsset("CascadeConfiguration")]
    public class UCascadeConfiguration : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}