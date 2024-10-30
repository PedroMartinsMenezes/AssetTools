namespace AssetTool
{
    [JsonAsset("PoseAssetFactory")]
    public class UPoseAssetFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}