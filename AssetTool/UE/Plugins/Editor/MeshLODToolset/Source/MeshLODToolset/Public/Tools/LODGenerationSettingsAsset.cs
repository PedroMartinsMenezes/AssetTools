namespace AssetTool
{
    [JsonAsset("StaticMeshLODGenerationSettings")]
    public class UStaticMeshLODGenerationSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}