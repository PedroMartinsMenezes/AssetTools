namespace AssetTool
{
    [JsonAsset("TimecodeSynchronizerFactory")]
    public class UTimecodeSynchronizerFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}