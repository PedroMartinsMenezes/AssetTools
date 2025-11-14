namespace AssetTool
{
    [JsonAsset("BlueprintComponentNodeSpawner")]
    public class UBlueprintComponentNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}