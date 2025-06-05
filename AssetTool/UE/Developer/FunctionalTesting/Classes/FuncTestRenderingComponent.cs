namespace AssetTool
{
    [JsonAsset("FuncTestRenderingComponent")]
    public class UFuncTestRenderingComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}