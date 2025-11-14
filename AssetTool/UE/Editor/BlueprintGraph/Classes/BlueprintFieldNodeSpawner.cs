namespace AssetTool
{
    [JsonAsset("BlueprintFieldNodeSpawner")]
    public class UBlueprintFieldNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}