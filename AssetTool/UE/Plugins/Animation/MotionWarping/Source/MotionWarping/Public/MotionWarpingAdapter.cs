namespace AssetTool
{
    [JsonAsset("MotionWarpingBaseAdapter")]
    public class UMotionWarpingBaseAdapter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}