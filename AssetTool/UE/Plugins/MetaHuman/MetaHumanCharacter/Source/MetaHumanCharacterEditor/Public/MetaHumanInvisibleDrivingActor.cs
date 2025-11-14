namespace AssetTool
{
    [JsonAsset("MetaHumanInvisibleDrivingActor")]
    public class AMetaHumanInvisibleDrivingActor : ASkeletalMeshActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}