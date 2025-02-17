namespace AssetTool
{
    [JsonAsset("BlueprintVariableNodeSpawner")]
    public class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}