namespace AssetTool
{
    [JsonAsset("MotionWarpingMoverAdapter")]
    public class UMotionWarpingMoverAdapter : UMotionWarpingBaseAdapter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}