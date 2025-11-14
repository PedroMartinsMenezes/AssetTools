namespace AssetTool
{
    [JsonAsset("MotionWarpingCharacterAdapter")]
    public class UMotionWarpingCharacterAdapter : UMotionWarpingBaseAdapter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}