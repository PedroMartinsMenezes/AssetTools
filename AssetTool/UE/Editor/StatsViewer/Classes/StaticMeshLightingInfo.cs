namespace AssetTool
{
    [JsonAsset("StaticMeshLightingInfo")]
    public class UStaticMeshLightingInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}