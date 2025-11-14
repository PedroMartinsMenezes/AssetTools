namespace AssetTool
{
    [JsonAsset("BlueprintBoundNodeSpawner")]
    public class UBlueprintBoundNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}