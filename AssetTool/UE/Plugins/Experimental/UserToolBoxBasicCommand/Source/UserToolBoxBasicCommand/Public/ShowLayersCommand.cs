namespace AssetTool
{
    [JsonAsset("ShowLayersCommand")]
    public class UShowLayersCommand : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}