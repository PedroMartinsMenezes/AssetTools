namespace AssetTool
{
    [JsonAsset("BlueprintAssetNodeSpawner")]
    public class UBlueprintAssetNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}