namespace AssetTool
{
    [JsonAsset("MetaHumanPerformanceControlRigComponent")]
    public class UMetaHumanPerformanceControlRigComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}