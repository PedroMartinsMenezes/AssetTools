namespace AssetTool
{
    [JsonAsset("RuntimeMesh")]
    public class URuntimeMesh : UStaticMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}