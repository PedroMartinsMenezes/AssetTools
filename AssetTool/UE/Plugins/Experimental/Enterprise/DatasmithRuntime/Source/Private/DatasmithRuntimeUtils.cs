namespace AssetTool
{
    [JsonAsset("RuntimeMesh")]
    public class URuntimeMesh : UStaticMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}