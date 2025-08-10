namespace AssetTool
{
    [JsonAsset("MetaHumanTemplateMeshComponent")]
    public class UMetaHumanTemplateMeshComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}