namespace AssetTool
{
    [JsonAsset("MetaHumanPerformanceControlRigComponent")]
    public class UMetaHumanPerformanceControlRigComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}