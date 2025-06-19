namespace AssetTool
{
    [JsonAsset("AssetEditor")]
    public class UAssetEditor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}