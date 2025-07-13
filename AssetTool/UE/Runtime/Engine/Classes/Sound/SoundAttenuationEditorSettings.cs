namespace AssetTool
{
    [JsonAsset("SoundAttenuationEditorSettings")]
    public class USoundAttenuationEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}