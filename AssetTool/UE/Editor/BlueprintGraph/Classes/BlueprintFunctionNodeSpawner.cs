namespace AssetTool
{
    [JsonAsset("BlueprintFunctionNodeSpawner")]
    public class UBlueprintFunctionNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}