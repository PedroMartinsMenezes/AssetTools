namespace AssetTool
{
    [JsonAsset("TextRenderComponent")]
    public class UTextRenderComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}