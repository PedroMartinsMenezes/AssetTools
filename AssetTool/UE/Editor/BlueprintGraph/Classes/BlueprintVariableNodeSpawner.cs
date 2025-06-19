namespace AssetTool
{
    [JsonAsset("BlueprintVariableNodeSpawner")]
    public class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}