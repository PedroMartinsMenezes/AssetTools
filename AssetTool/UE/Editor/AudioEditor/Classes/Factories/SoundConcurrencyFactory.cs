namespace AssetTool
{
    [JsonAsset("SoundConcurrencyFactory")]
    public class USoundConcurrencyFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}