namespace AssetTool
{
    [JsonAsset("CommonPlayerInputKey")]
    public class UCommonPlayerInputKey : UCommonUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}