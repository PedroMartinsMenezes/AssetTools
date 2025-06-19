namespace AssetTool
{
    [JsonAsset("TextRenderComponent")]
    public class UTextRenderComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}