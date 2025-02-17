namespace AssetTool
{
    [JsonAsset("BlueprintFunctionNodeSpawner")]
    public class UBlueprintFunctionNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}