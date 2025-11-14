namespace AssetTool
{
    [JsonAsset("BlueprintVariableNodeSpawner")]
    public class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}