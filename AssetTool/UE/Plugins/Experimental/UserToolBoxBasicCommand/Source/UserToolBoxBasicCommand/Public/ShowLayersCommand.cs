namespace AssetTool
{
    [JsonAsset("ShowLayersCommand")]
    public class UShowLayersCommand : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}