namespace AssetTool
{
    [JsonAsset("MeshBudgetProjectSettings")]
    public class UMeshBudgetProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}