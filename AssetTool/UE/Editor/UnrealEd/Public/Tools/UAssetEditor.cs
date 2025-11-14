namespace AssetTool
{
    [JsonAsset("AssetEditor")]
    public class UAssetEditor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}