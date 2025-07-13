namespace AssetTool
{
    [JsonAsset("MeshBudgetProjectSettings")]
    public class UMeshBudgetProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}