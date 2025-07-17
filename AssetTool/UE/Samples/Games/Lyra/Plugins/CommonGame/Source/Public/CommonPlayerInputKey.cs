namespace AssetTool
{
    [JsonAsset("CommonPlayerInputKey")]
    public class UCommonPlayerInputKey : UCommonUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}