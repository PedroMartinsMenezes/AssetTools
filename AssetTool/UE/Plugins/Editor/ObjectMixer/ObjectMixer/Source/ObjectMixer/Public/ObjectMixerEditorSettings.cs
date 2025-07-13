namespace AssetTool
{
    [JsonAsset("ObjectMixerEditorSettings")]
    public class UObjectMixerEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}