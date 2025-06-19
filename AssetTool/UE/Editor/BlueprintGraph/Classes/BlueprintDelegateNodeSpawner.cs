namespace AssetTool
{
    [JsonAsset("BlueprintDelegateNodeSpawner")]
    public class UBlueprintDelegateNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}