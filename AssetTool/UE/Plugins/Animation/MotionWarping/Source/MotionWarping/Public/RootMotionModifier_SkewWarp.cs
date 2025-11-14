namespace AssetTool
{
    [JsonAsset("RootMotionModifier_SkewWarp")]
    public class URootMotionModifier_SkewWarp : URootMotionModifier_Warp
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}