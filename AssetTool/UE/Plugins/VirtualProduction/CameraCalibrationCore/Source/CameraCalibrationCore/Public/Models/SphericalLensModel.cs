namespace AssetTool
{
    [JsonAsset("SphericalLensModel")]
    public class USphericalLensModel : ULensModel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}