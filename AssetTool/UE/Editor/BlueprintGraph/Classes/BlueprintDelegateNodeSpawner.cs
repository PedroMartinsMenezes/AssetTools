namespace AssetTool
{
    [JsonAsset("BlueprintDelegateNodeSpawner")]
    public class UBlueprintDelegateNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}