namespace AssetTool
{
    [JsonAsset("AnamorphicLensModel")]
    public class UAnamorphicLensModel : ULensModel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}