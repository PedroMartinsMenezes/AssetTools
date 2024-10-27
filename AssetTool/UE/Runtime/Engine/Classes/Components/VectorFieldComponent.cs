namespace AssetTool
{
    [JsonAsset("VectorFieldComponent")]
    public class UVectorFieldComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}