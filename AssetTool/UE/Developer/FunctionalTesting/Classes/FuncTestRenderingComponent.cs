namespace AssetTool
{
    [JsonAsset("FuncTestRenderingComponent")]
    public class UFuncTestRenderingComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}