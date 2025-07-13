namespace AssetTool
{
    [JsonAsset("StaticMeshLODGenerationSettings")]
    public class UStaticMeshLODGenerationSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}