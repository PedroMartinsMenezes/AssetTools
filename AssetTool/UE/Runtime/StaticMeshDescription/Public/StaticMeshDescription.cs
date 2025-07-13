namespace AssetTool
{
    [JsonAsset("StaticMeshDescription")]
    public class UStaticMeshDescription : UMeshDescriptionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}