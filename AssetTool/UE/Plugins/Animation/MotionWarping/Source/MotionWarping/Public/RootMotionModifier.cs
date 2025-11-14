namespace AssetTool
{
    [JsonAsset("RootMotionModifier")]
    public class URootMotionModifier : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RootMotionModifier_Warp")]
    public class URootMotionModifier_Warp : URootMotionModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RootMotionModifier_SimpleWarp")]
    public class UDEPRECATED_RootMotionModifier_SimpleWarp : URootMotionModifier_Warp
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RootMotionModifier_Scale")]
    public class URootMotionModifier_Scale : URootMotionModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}