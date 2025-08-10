namespace AssetTool
{
    [JsonAsset("MetaHumanFootageComponent")]
    public class UMetaHumanFootageComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}