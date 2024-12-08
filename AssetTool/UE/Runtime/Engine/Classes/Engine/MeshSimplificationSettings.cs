namespace AssetTool
{
    [JsonAsset("MeshSimplificationSettings")]
    public class UMeshSimplificationSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}