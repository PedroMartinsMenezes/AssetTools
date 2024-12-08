namespace AssetTool
{
    [JsonAsset("PoseWatchFolder")]
    public class UPoseWatchFolder : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PoseWatchElement")]
    public class UPoseWatchElement : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PoseWatchPoseElement")]
    public class UPoseWatchPoseElement : UPoseWatchElement
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PoseWatch")]
    public class UPoseWatch : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}