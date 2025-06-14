namespace AssetTool
{
    [JsonAsset("RootMotionModifier_SkewWarp")]
    public class URootMotionModifier_SkewWarp : URootMotionModifier_Warp
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}