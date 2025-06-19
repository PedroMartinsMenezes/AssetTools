namespace AssetTool
{
    [JsonAsset("CommonUserWidget")]
    public class UCommonUserWidget : UUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}