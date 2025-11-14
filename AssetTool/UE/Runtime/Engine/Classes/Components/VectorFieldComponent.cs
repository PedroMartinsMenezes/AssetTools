namespace AssetTool
{
    [JsonAsset("VectorFieldComponent")]
    public class UVectorFieldComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}