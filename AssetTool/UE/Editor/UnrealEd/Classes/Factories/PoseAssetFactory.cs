namespace AssetTool
{
    [JsonAsset("PoseAssetFactory")]
    public class UPoseAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}