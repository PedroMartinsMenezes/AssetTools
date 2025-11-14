namespace AssetTool
{
    [JsonAsset("MeshDescriptionBase")]
    public class UMeshDescriptionBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}