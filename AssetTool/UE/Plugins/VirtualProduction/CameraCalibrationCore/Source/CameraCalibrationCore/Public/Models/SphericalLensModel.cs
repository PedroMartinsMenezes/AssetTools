namespace AssetTool
{
    [JsonAsset("SphericalLensModel")]
    public class USphericalLensModel : ULensModel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}