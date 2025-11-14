namespace AssetTool
{
    [JsonAsset("MetaHumanFootageComponent")]
    public class UMetaHumanFootageComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}