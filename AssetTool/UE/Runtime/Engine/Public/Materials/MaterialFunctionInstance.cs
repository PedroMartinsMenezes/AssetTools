namespace AssetTool
{
    [JsonAsset("MaterialFunctionInstance")]
    public class UMaterialFunctionInstance : UMaterialFunctionInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}