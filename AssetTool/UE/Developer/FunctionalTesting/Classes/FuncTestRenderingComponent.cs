namespace AssetTool
{
    [JsonAsset("FuncTestRenderingComponent")]
    public class UFuncTestRenderingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}