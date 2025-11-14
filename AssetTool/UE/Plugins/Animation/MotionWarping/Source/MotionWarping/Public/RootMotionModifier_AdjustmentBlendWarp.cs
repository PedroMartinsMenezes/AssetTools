namespace AssetTool
{
    [JsonAsset("RootMotionModifier_AdjustmentBlendWarp")]
    public class URootMotionModifier_AdjustmentBlendWarp : URootMotionModifier_Warp
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}