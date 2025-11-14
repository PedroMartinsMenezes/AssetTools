namespace AssetTool
{
    [JsonAsset("MeshSimplificationSettings")]
    public class UMeshSimplificationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}