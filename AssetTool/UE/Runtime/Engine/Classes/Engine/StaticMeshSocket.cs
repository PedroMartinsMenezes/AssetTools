namespace AssetTool
{
    [JsonAsset("StaticMeshSocket")]
    public class UStaticMeshSocket : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}