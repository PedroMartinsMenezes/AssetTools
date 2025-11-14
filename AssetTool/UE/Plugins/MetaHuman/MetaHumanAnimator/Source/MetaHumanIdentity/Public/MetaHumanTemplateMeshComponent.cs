namespace AssetTool
{
    [JsonAsset("MetaHumanTemplateMeshComponent")]
    public class UMetaHumanTemplateMeshComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}