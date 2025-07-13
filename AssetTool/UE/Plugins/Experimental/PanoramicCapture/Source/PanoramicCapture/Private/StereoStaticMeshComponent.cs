namespace AssetTool
{
    [JsonAsset("StereoStaticMeshComponent")]
    public class UStereoStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}