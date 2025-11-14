namespace AssetTool
{
    [JsonAsset("GroomBindingAsset")]
    public class UGroomBindingAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomBindingAssetList")]
    public class UGroomBindingAssetList : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}