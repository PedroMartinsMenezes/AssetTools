namespace AssetTool
{
    [JsonAsset("BlueprintFieldNodeSpawner")]
    public class UBlueprintFieldNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}