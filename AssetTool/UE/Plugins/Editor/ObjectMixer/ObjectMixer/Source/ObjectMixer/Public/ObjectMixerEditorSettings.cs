namespace AssetTool
{
    [JsonAsset("ObjectMixerEditorSettings")]
    public class UObjectMixerEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}