namespace AssetTool
{
    [JsonAsset("SoundAttenuationEditorSettings")]
    public class USoundAttenuationEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}