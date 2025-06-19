namespace AssetTool
{
    [JsonAsset("CommonRotator")]
    public class UCommonRotator : UCommonButtonBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}