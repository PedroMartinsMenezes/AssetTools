namespace AssetTool
{
    [JsonAsset("BlueprintDelegateNodeSpawner")]
    public class UBlueprintDelegateNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}