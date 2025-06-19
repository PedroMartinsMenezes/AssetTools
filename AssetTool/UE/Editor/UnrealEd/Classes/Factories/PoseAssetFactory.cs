namespace AssetTool
{
    [JsonAsset("PoseAssetFactory")]
    public class UPoseAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}