namespace AssetTool
{
    [JsonAsset("LensModel")]
    public class ULensModel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}