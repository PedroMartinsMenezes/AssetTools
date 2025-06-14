namespace AssetTool
{
    [JsonAsset("MotionWarpingBaseAdapter")]
    public class UMotionWarpingBaseAdapter : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}