namespace AssetTool
{
    [JsonAsset("UTBBaseCommand")]
    public class UUTBBaseCommand : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}