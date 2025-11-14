namespace AssetTool
{
    [JsonAsset("MotionWarpingBaseAdapter")]
    public class UMotionWarpingBaseAdapter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}