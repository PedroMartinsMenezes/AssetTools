namespace AssetTool
{
    [JsonAsset("MotionWarpingMoverAdapter")]
    public class UMotionWarpingMoverAdapter : UMotionWarpingBaseAdapter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}