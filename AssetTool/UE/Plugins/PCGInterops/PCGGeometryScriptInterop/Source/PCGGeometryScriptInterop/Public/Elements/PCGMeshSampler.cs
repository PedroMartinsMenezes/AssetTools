namespace AssetTool
{
    [JsonAsset("PCGMeshSamplerSettings")]
    public class UPCGMeshSamplerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}