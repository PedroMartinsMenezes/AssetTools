namespace AssetTool
{
    [JsonAsset("StereoStaticMeshComponent")]
    public class UStereoStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}