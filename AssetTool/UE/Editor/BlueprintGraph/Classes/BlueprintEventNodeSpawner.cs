namespace AssetTool
{
    [JsonAsset("BlueprintEventNodeSpawner")]
    public class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}