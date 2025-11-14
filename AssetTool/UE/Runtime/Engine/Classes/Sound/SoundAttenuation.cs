namespace AssetTool
{
    [JsonAsset("SoundAttenuation")]
    public class USoundAttenuation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}