namespace AssetTool
{
    [JsonAsset("CommonUserWidget")]
    public class UCommonUserWidget : UUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}