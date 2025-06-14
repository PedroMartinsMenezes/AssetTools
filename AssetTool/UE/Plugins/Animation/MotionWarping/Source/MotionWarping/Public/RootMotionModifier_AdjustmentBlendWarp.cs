namespace AssetTool
{
    [JsonAsset("RootMotionModifier_AdjustmentBlendWarp")]
    public class URootMotionModifier_AdjustmentBlendWarp : URootMotionModifier_Warp
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}