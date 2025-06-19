namespace AssetTool
{
    [JsonAsset("MotionWarpingCharacterAdapter")]
    public class UMotionWarpingCharacterAdapter : UMotionWarpingBaseAdapter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}