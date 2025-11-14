namespace AssetTool
{
    [JsonAsset("TimecodeSynchronizerFactory")]
    public class UTimecodeSynchronizerFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}