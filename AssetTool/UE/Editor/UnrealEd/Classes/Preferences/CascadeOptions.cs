namespace AssetTool
{
    [JsonAsset("CascadeOptions")]
    public class UCascadeOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}