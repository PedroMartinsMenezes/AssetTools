namespace AssetTool
{
    [JsonAsset("MetaHumanInvisibleDrivingActor")]
    public class AMetaHumanInvisibleDrivingActor : ASkeletalMeshActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}