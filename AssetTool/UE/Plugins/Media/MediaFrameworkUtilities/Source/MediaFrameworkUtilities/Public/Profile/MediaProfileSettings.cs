namespace AssetTool
{
    [JsonAsset("MediaProfileSettings")]
    public class UMediaProfileSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaProfileEditorSettings")]
    public class UMediaProfileEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}