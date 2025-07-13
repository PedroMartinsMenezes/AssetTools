namespace AssetTool
{
    [JsonAsset("PCGMeshSamplerSettings")]
    public class UPCGMeshSamplerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}