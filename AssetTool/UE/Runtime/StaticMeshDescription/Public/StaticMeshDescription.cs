namespace AssetTool
{
    [JsonAsset("StaticMeshDescription")]
    public class UStaticMeshDescription : UMeshDescriptionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}