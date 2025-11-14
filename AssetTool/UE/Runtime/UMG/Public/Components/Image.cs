namespace AssetTool
{
    [JsonAsset("Image")]
    public class UImage : UWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}