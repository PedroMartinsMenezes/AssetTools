namespace AssetTool
{
    [JsonAsset("VectorFieldComponent")]
    public class UVectorFieldComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}