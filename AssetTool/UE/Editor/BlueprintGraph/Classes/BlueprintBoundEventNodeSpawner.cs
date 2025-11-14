namespace AssetTool
{
    [JsonAsset("BlueprintBoundEventNodeSpawner")]
    public class UBlueprintBoundEventNodeSpawner : UBlueprintEventNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}