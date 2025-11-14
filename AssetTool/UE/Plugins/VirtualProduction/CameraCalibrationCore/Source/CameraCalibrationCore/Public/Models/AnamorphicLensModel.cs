namespace AssetTool
{
    [JsonAsset("AnamorphicLensModel")]
    public class UAnamorphicLensModel : ULensModel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}