namespace AssetTool
{
    [JsonAsset("StaticMeshLightingInfo")]
    public class UStaticMeshLightingInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}