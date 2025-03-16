namespace AssetTool
{
    [JsonAsset("VectorFieldStatic")]
    public class UVectorFieldStatic : UVectorField
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}