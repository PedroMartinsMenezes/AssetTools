namespace AssetTool
{
    [JsonAsset("MeshSimplificationSettings")]
    public class UMeshSimplificationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}