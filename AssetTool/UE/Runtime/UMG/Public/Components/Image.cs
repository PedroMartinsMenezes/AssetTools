namespace AssetTool
{
    [JsonAsset("Image")]
    public class UImage : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}