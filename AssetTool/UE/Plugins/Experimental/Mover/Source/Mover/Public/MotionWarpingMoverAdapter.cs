namespace AssetTool
{
    [JsonAsset("MotionWarpingMoverAdapter")]
    public class UMotionWarpingMoverAdapter : UMotionWarpingBaseAdapter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}