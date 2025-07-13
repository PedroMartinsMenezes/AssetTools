namespace AssetTool
{
    [JsonAsset("TimecodeSynchronizerProjectSettings")]
    public class UTimecodeSynchronizerProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TimecodeSynchronizerEditorSettings")]
    public class UTimecodeSynchronizerEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}